
using ContentsLimitInsurance.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContentsLimitInsurance.Data
{
    public class ContentsLimitContext : DbContext
    {
        public ContentsLimitContext(DbContextOptions<ContentsLimitContext> options)
            : base(options)
        { }

        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetCategory> AssetCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region AssetCategory Seed

            #endregion
        }
    }
}
