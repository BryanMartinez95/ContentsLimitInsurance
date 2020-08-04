using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ContentsLimitInsurance.Infrastructure.Service;
using ContentsLimitInsurance.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContentsLimitInsurance.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssetCategoryController : ControllerBase
    {
        private readonly IAssetCategoryService _assetCategoryService;

        public AssetCategoryController(IAssetCategoryService assetCategoryService)
        {
            _assetCategoryService = assetCategoryService;
        }


        [HttpGet("GetList")]
        [ProducesResponseType(typeof(List<AssetCategoryDto>), (int)HttpStatusCode.OK)]
        public async Task<List<AssetCategoryDto>> GetList()
        {
            return await _assetCategoryService.GetListAsync();
        }
    }
}
