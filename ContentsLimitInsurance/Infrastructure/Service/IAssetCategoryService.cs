
using System.Collections.Generic;
using System.Threading.Tasks;
using ContentsLimitInsurance.Models;

namespace ContentsLimitInsurance.Infrastructure.Service
{
    public interface IAssetCategoryService
    {
        Task<List<AssetCategoryDto>> GetListAsync();
    }
}
