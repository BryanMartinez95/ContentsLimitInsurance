
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using AutoMapper;
using ContentsLimitInsurance.Data.Entities;
using ContentsLimitInsurance.Infrastructure.Automapper;
using ContentsLimitInsurance.Infrastructure.Service;
using ContentsLimitInsurance.Models;
using Microsoft.EntityFrameworkCore.Internal;
using Xunit;

namespace ContentsLimitInsurance.IntegrationTests.Services
{
    public class AssetServiceTests : BaseTest
    {
        private readonly Guid _jewelryCategoryId = new Guid("0aea976d-1775-499d-a6de-44c7874bd550");
        private readonly Guid _kitchenCategoryId = new Guid("9a5b7778-a5d8-45ea-bab3-4e3dc6e2c589");

        private Asset _firstAsset { get; set; }
        private Asset _secondAsset { get; set; }
        private AssetCategory _firstAssetCategory { get; set; }
        private AssetCategory _secondAssetCategory { get; set; }

        public AssetServiceTests()
        {
            var _firstAssetCategory = new AssetCategory
            {
                Id = _jewelryCategoryId,
                Name = "Jewelry",
                IsDeleted = false
            };
            _context.AssetCategories.Add(_firstAssetCategory);


            var _secondAssetCategory = new AssetCategory
            {
                Id = _kitchenCategoryId,
                Name = "Kitchen",
                IsDeleted = false
            };
            _context.AssetCategories.Add(_firstAssetCategory);


            _firstAsset = new Asset
            {
                Id = new Guid("ba4ed432-7dba-4ee0-9782-1abab50a4597"),
                Name = "Necklace",
                IsDeleted = false,
                AssetCategoryId = _jewelryCategoryId,
                Value = 200
            };
            _context.Assets.Add(_firstAsset);

            _secondAsset = new Asset
            {
                Id = new Guid("3f3ee740-67b3-47d5-b3d2-6533aa91aa3e"),
                Name = "Earrings",
                IsDeleted = false,
                AssetCategoryId = _jewelryCategoryId,
                Value = 333.22
            };
            _context.Assets.Add(_secondAsset);


            _context.SaveChanges();
        }

        [Fact]
        public async Task GetAsyncShouldReturnItem()
        {
            var service = new AssetService(_mapper, _context);
            var asset = await service.GetAsync(new Guid("ba4ed432-7dba-4ee0-9782-1abab50a4597"));
            Assert.Equal(asset.Id, _firstAsset.Id);
        }

        [Fact]
        public async Task GetAssetGroupListAsync()
        {
            var service = new AssetService(_mapper, _context);
            var groupList = await service.GetAssetGroupListAsync();

            Assert.Equal(4,groupList.Count);
            var jewelry = groupList.FirstOrDefault(x => x.GroupById == _jewelryCategoryId);
            Assert.Equal(533.22,jewelry?.Total);

        }

        [Fact]
        public async Task CreateAssetAsync()
        {
            var assetDtoResponse = new AssetDtoResponse
            {
                ItemCategory = _jewelryCategoryId,
                ItemName = "Ring",
                ItemValue = 50
            };

            var service = new AssetService(_mapper, _context);
            var id = await service.CreateAssetAsync(assetDtoResponse);

            var asset = await service.GetAsync(id);
            Assert.NotNull(asset);

        }


        [Theory]
        [InlineData("ba4ed432-7dba-4ee0-9782-1abab50a4597")]
        [InlineData("3f3ee740-67b3-47d5-b3d2-6533aa91aa3e")]
        public async Task DeleteAssetShouldDelete(string idString)
        {
            var id = new Guid(idString);
            var service = new AssetService(_mapper, _context);
            var success = await service.DeleteAsset(id);
            Assert.True(success);
        }
    }
}
