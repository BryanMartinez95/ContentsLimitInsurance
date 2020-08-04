using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ContentsLimitInsurance.Entities;
using ContentsLimitInsurance.Models;
using Microsoft.EntityFrameworkCore;

namespace ContentsLimitInsurance.Infrastructure.Service
{
    public class AssetService : IAssetService
    {
        private readonly IMapper _mapper;
        private readonly ContentsLimitContext _context;

        public AssetService(IMapper mapper, ContentsLimitContext context)
        {
            _mapper = mapper;
            _context = context;
        }


        public async Task<Asset> GetAsync(Guid id)
        {
            return await _context.Assets.FindAsync(id);
        }

        public async Task<List<AssetGroupDto>> GetAssetGroupListAsync()
        {

            //get all assets, then map to  AssetDto, then group by category.
            //can refactor later to group by different fields
            var assetListGroup = _mapper.Map<List<AssetDto>>(
               await _context.Assets.Include("AssetCategory").Where(x => x.IsDeleted == false).ToListAsync()).OrderBy(x=> x.AssetCategoryName).GroupBy(x => x.AssetCategoryId);
            var groupByList = new List<AssetGroupDto>();

            var assetCategories = _context.AssetCategories.Where(x => x.IsDeleted == false).ToList();
            foreach (var assetGroup in assetListGroup)
            {
                groupByList.Add(new AssetGroupDto
                {
                    GroupById = assetGroup.Key,
                    GroupByValue = assetCategories.FirstOrDefault(x => x.Id == assetGroup.Key)?.Name,
                    Total = assetGroup.Select(x => x.Value).Sum(),
                    AssetList = assetGroup.ToList()

                });
            }
            return groupByList;
        }

        public async Task<Guid> CreateAssetAsync(AssetDtoResponse assetDtoResponse)
        {
            var asset = _mapper.Map<Asset>(assetDtoResponse);

            asset.Id = Guid.NewGuid();

            _context.Assets.Add(asset);
            await _context.SaveChangesAsync();

            return asset.Id;
        }

        //entity needs to be in tracking/db memory
        public async Task<bool> DeleteAsset(Asset asset)
        {
            asset.IsDeleted = true;
            return await _context.SaveChangesAsync() > 0;
        }


        //get by id first then update IsDeleted
        public async Task<bool> DeleteAsset(Guid id)
        {
            var asset = await _context.Assets.FindAsync(id);
            if (asset == null)
            {
                return false;
            }
            asset.IsDeleted = true;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
