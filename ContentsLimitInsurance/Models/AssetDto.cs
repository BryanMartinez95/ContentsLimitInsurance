using System;
using AutoMapper;
using ContentsLimitInsurance.Entities;
using ContentsLimitInsurance.Infrastructure.Automapper;

namespace ContentsLimitInsurance.Models
{
    public class AssetDto : ICustomMapping
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double Value { get; set; }
        public bool IsDeleted { get; set; }



        public string AssetCategoryName { get; set; }
        public Guid AssetCategoryId { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Asset, AssetDto>()
                .ForMember(x => x.AssetCategoryName, y => y.MapFrom(s => s.AssetCategory != null ? s.AssetCategory.Name : null));
        }
    }
}
