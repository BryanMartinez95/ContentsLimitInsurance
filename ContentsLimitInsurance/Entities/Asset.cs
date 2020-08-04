using System;

namespace ContentsLimitInsurance.Entities
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime? DatePurchased { get; set; }
        public double Value { get; set; }
        public bool IsDeleted { get; set; }


        public Guid AssetCategoryId { get; set; }
        public AssetCategory AssetCategory { get; set; }
        
    }
}
