using System;
using ContentsLimitInsurance.Entities;
using ContentsLimitInsurance.Infrastructure.Automapper;

namespace ContentsLimitInsurance.Models
{
    public class AssetCategoryDto : ICustomMapping
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public void CreateMappings(AutoMapper.Profile configuration)
        {
            configuration.CreateMap<AssetCategory, AssetCategoryDto>();
        }
    }

}
