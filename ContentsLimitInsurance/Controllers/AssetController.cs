
using System;
using System.Collections.Generic;
using AutoMapper;
using ContentsLimitInsurance.Data.Entities;
using ContentsLimitInsurance.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContentsLimitInsurance.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetController : ControllerBase
    {
        private readonly IMapper _mapper;

        public AssetController(IMapper mapper)
        {
            _mapper = mapper;

        }


        [HttpGet]
        public IEnumerable<AssetDto> Get()
        {
            var assetPlaceholder = new Asset
            {
                Id = Guid.Empty,
                Value = 200,
                Name = "Chocolate",
                IsDeleted = false

            };

            var dto = _mapper.Map<AssetDto>(assetPlaceholder);

            var list = new List<AssetDto>();
            list.Add(dto);
            return list;
        }
    }
}
