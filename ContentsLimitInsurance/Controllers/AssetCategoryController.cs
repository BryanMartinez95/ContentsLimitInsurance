using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ContentsLimitInsurance.Data;
using ContentsLimitInsurance.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContentsLimitInsurance.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetCategoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ContentsLimitContext _context;

        public AssetCategoryController(IMapper mapper, ContentsLimitContext context)
        {
            _mapper = mapper;
            _context = context;
        }


        [HttpGet]
        public IEnumerable<AssetCategoryDto> Get()
        {
            return _mapper.Map<List<AssetCategoryDto>>(_context.AssetCategories.Where(x => x.IsDeleted == false).ToList());
        }
    }
}
