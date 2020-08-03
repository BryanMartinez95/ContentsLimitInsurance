
using System;
using ContentsLimitInsurance.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContentsLimitInsurance.Data
{
    public class ContentsLimitContext : DbContext
    {
        public ContentsLimitContext(DbContextOptions<ContentsLimitContext> options) : base(options)
        {

        }


        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetCategory> AssetCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region AssetCategory Seed

            modelBuilder.Entity<AssetCategory>().HasData(new AssetCategory { Id = new Guid("64bc457a-e276-4ff4-ac5f-fbf0511eb5ab"), Name = "Electronics", IsDeleted = false });
            modelBuilder.Entity<AssetCategory>().HasData(new AssetCategory { Id = new Guid("3b2320c7-8267-4b98-9593-702b1eb2e2cf"), Name = "Clothing", IsDeleted = false });
            modelBuilder.Entity<AssetCategory>().HasData(new AssetCategory { Id = new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"), Name = "Kitchen", IsDeleted = false });

            #endregion


            #region Asset Seed


            modelBuilder.Entity<Asset>().HasData(new Asset{ Id = Guid.NewGuid(),Value=2000, Name = "TV", IsDeleted = false, AssetCategoryId = new Guid("64bc457a-e276-4ff4-ac5f-fbf0511eb5ab"), Location= "Living Room", DatePurchased = new DateTime() });
            modelBuilder.Entity<Asset>().HasData(new Asset{ Id = Guid.NewGuid(),Value=400, Name = "Playstation", IsDeleted = false, AssetCategoryId = new Guid("64bc457a-e276-4ff4-ac5f-fbf0511eb5ab"), Location="Living Room",DatePurchased = new DateTime() });
            modelBuilder.Entity<Asset>().HasData(new Asset{ Id = Guid.NewGuid(),Value=1600, Name = "Stereo", IsDeleted = false, AssetCategoryId = new Guid("64bc457a-e276-4ff4-ac5f-fbf0511eb5ab"), Location="Bedroom",DatePurchased = new DateTime() });
            modelBuilder.Entity<Asset>().HasData(new Asset{ Id = Guid.NewGuid(),Value=1100, Name = "Shirts", IsDeleted = false, AssetCategoryId = new Guid("3b2320c7-8267-4b98-9593-702b1eb2e2cf"), Location="Bedroom",DatePurchased = new DateTime() });
            modelBuilder.Entity<Asset>().HasData(new Asset{ Id = Guid.NewGuid(),Value=1100, Name = "Jeans", IsDeleted = false, AssetCategoryId = new Guid("3b2320c7-8267-4b98-9593-702b1eb2e2cf"), Location="Bedroom",DatePurchased = new DateTime() });
            modelBuilder.Entity<Asset>().HasData(new Asset{ Id = Guid.NewGuid(),Value=3000, Name = "Pots and Pans", IsDeleted = false, AssetCategoryId = new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"), Location="Kitchen",DatePurchased = new DateTime() });
            modelBuilder.Entity<Asset>().HasData(new Asset{ Id = Guid.NewGuid(),Value=500, Name = "Flatware", IsDeleted = false, AssetCategoryId = new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"), Location="Kitchen",DatePurchased = new DateTime() });
            modelBuilder.Entity<Asset>().HasData(new Asset{ Id = Guid.NewGuid(),Value=500, Name = "Knife Set", IsDeleted = false, AssetCategoryId = new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"), Location="Kitchen",DatePurchased = new DateTime() });
            modelBuilder.Entity<Asset>().HasData(new Asset{ Id = Guid.NewGuid(),Value=1000, Name = "Misc", IsDeleted = false, AssetCategoryId = new Guid("44a4685a-9485-486b-b8d9-75553fb6f3f0"), Location="Kitchen",DatePurchased = new DateTime() });

            #endregion

            
        }
    }
}
