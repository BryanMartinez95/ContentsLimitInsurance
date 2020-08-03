
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using ContentsLimitInsurance.Data;
using ContentsLimitInsurance.Data.Entities;
using ContentsLimitInsurance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContentsLimitInsurance.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ContentsLimitContext _context;


        public AssetController(IMapper mapper,ContentsLimitContext context)
        {
            _mapper = mapper;
            _context = context;
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<AssetGroupDto>), (int)HttpStatusCode.OK)]
        public List<AssetGroupDto> GetAssetGroupList()
        {
            var assetListGroup = _mapper.Map<List<AssetDto>>(_context.Assets.Include("AssetCategory").Where(x => x.IsDeleted == false).ToList()).GroupBy(x=> x.AssetCategoryId);
            var groupByList = new List<AssetGroupDto>();

            var assetCategories = _context.AssetCategories.Where(x=> x.IsDeleted == false).ToList();
            foreach (var assetGroup in assetListGroup)
            {
                groupByList.Add(new AssetGroupDto
                {
                    GroupById = assetGroup.Key,
                    GroupByValue = assetCategories.FirstOrDefault(x=> x.Id == assetGroup.Key)?.Name,
                    Total = assetGroup.Select(x=> x.Value).Sum(),
                    AssetList = assetGroup.ToList()

                });
            }
            return groupByList;
        }


        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<ActionResult> CreateAsset([FromBody]AssetDtoResponse assetDtoResponse)
        {
            if (assetDtoResponse == null)
            {
                return BadRequest();
            }

            var asset = _mapper.Map<Asset>(assetDtoResponse);
            asset.Id = Guid.NewGuid();
            _context.Assets.Add(asset);
            await _context.SaveChangesAsync();
            
            return CreatedAtAction(nameof(GetAssetGroupList), new { id = asset.Id },null);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult> DeleteAsset(Guid id)
        {
            var asset = _context.Assets.FirstOrDefault(x => x.Id == id);
            if (asset == null)
            {
                return NotFound();
                
            }
            asset.IsDeleted = true;
            await _context.SaveChangesAsync();

            return NoContent();
        }



    }
}
