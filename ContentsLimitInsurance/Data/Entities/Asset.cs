using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentsLimitInsurance.Data.Entities
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public bool IsDeleted { get; set; }


        public Guid AssetCategoryId { get; set; }
        public AssetCategory AssetCategory { get; set; }
        
    }
}
