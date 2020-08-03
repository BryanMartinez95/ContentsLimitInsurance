using System;
namespace ContentsLimitInsurance.Models
{
    public class AssetDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double Value { get; set; }
        public bool IsDeleted { get; set; }



        public string AssetCategoryName { get; set; }
        public Guid AssetCategoryId { get; set; }
    }
}
