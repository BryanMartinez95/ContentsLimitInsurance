using System;
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
    public class AssetController : ControllerBase
    {
        private readonly IAssetService _assetService;

        public AssetController(IAssetService assetService)
        {

            _assetService = assetService;
        }

        [HttpGet("GetAssetGroupList")]
        [ProducesResponseType(typeof(List<AssetGroupDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<AssetGroupDto>>> GetAssetGroupList()
        {
            return await _assetService.GetAssetGroupListAsync();
        }


        [HttpPost("CreateAsset")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<ActionResult> CreateAsset([FromBody]AssetDtoResponse assetDtoResponse)
        {
            if (assetDtoResponse == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var id = await _assetService.CreateAssetAsync(assetDtoResponse);

            return CreatedAtAction(nameof(GetAssetGroupList), new { id = id });
        }

        [HttpDelete("DeleteAsset/{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> DeleteAsset(Guid id)
        {
            var asset = await _assetService.GetAsync(id);

            if (asset == null)
            {
                return NotFound();
                
            }

            var success = await _assetService.DeleteAsset(asset);

            if (!success)
            {
                return BadRequest();
            }
            return NoContent();
        }



    }
}
