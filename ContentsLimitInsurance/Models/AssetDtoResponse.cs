using System;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using ContentsLimitInsurance.Data.Entities;
using ContentsLimitInsurance.Infrastructure.Annotations;
using ContentsLimitInsurance.Infrastructure.Automapper;

namespace ContentsLimitInsurance.Models
{
    public class AssetDtoResponse : ICustomMapping
    {
        [Required]
        public string ItemName { get; set; }

        [Range(1, 1000000)]
        public double ItemValue { get; set; }

        [NotEmptyGuid]
        public Guid ItemCategory { get; set; }


        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<AssetDtoResponse, Asset>()
                .ForMember(x => x.Name, y => y.MapFrom(s => s.ItemName))
                .ForMember(x => x.Value, y => y.MapFrom(s => s.ItemValue))
                .ForMember(x => x.AssetCategoryId, y => y.MapFrom(s => s.ItemCategory));
        }
    }
}
