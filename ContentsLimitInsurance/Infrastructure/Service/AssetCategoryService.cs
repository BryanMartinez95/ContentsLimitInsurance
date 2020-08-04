using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ContentsLimitInsurance.Data;
using ContentsLimitInsurance.Models;
using Microsoft.EntityFrameworkCore;

namespace ContentsLimitInsurance.Infrastructure.Service
{
    public class AssetCategoryService : IAssetCategoryService
    {
        private readonly IMapper _mapper;
        private readonly ContentsLimitContext _context;

        public AssetCategoryService(IMapper mapper, ContentsLimitContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<AssetCategoryDto>> GetListAsync()
        {
            //get AssetCategories then map to AssetCategoryDtos
            return _mapper.Map<List<AssetCategoryDto>>(await _context.AssetCategories.Where(x => x.IsDeleted == false).ToListAsync());
        }
    }
}
