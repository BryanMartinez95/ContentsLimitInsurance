using System;
using System.Collections.Generic;

namespace ContentsLimitInsurance.Entities
{
    public class AssetCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public List<Asset> Assets { get; set; }
    }
}
