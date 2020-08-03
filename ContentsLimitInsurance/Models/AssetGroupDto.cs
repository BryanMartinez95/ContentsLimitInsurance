using System;
using System.Collections.Generic;
using AutoMapper;
using ContentsLimitInsurance.Infrastructure.Automapper;

namespace ContentsLimitInsurance.Models
{
    public class AssetGroupDto : ICustomMapping
    {
        public AssetGroupDto()
        {
            AssetList =new List<AssetDto>();
        }

        public Guid? GroupById { get; set; }
        public string GroupByValue { get; set; }
        public double Total { get; set; }

        public List<AssetDto> AssetList { get; set; }

        public void CreateMappings(Profile configuration)
        {

        }
    }
}
