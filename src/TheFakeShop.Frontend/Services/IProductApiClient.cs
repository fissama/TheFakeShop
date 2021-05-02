using TheFakeShop.ShareModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TheFakeShop.Frontend.Services
{
    public interface IProductApiClient
    {
        Task<IList<ProductViewModel>> GetProducts();

        Task<IList<ProductViewModel>> GetSearchProducts(string searchContent);

        Task<ProductViewModel> GetProductById(int id);

        Task<IList<ProductViewModel>> GetProductsByCategoryId(int id);

        Task<bool> Rating(RatingCreateRequest rateRequest);
    }
}