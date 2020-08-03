
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<AssetDto> Get()
        {
            // return _mapper.Map<List<AssetDto>>(_context.Assets.Include("AssetCategory").Where(x => x.IsDeleted == false).ToList()).GroupBy(x=> x.AssetCategoryName);
            return _mapper.Map<List<AssetDto>>(_context.Assets.Include("AssetCategory").Where(x => x.IsDeleted == false).ToList());
        }




        [HttpPost]
        public async Task<ActionResult<AssetDto>> CreateAsset(AssetDto assetDto)
        {
            var asset = _mapper.Map<Asset>(assetDto);
            asset.Id = Guid.NewGuid();
            _context.Assets.Add(asset);
            await _context.SaveChangesAsync();

            return assetDto;
        }

        [HttpDelete]
        public async Task<int> DeleteAsset(Guid id)
        {
            return 0;
        }



    }
}
