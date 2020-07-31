using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ContentsLimitInsurance.Data.Entities;
using ContentsLimitInsurance.Models;

namespace ContentsLimitInsurance.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Asset, AssetDto>();
            CreateMap<AssetCategory, AssetCategoryDto>();
        }
    }
}
