using System;
using AutoMapper;
using ContentsLimitInsurance.Data.Entities;
using ContentsLimitInsurance.Infrastructure.Automapper;

namespace ContentsLimitInsurance.Models
{
    public class AssetDtoResponse : ICustomMapping
    {
        public string ItemName { get; set; }
        public double ItemValue { get; set; }
        public Guid? ItemCategory { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<AssetDtoResponse, Asset>()
                .ForMember(x => x.Name, y => y.MapFrom(s => s.ItemName))
                .ForMember(x => x.Value, y => y.MapFrom(s => s.ItemValue))
                .ForMember(x => x.AssetCategoryId, y => y.MapFrom(s => s.ItemCategory));
        }
    }
}
