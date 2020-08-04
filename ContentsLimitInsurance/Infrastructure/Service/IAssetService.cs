using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ContentsLimitInsurance.Data.Entities;
using ContentsLimitInsurance.Models;

namespace ContentsLimitInsurance.Infrastructure.Service
{
    public interface IAssetService
    {
        Task<Asset> GetAsync(Guid id);
        Task<List<AssetGroupDto>> GetAssetGroupListAsync();
        Task<Guid> CreateAssetAsync(AssetDtoResponse assetDtoResponse);

        //entity needs to be in db tracking
        Task<bool> DeleteAsset(Asset asset);

    }
}
