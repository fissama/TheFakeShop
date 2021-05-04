using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;

namespace TheFakeShop.Backend.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ReadAllProduct();

        Task<IEnumerable<Product>> ReadSearchProducts(string searchContent);

        Task<IEnumerable<Product>> ReadProductByCategoryId(int id);

        Task<Product> ReadProductById(int id);

        Task<bool> CreateProduct(Product Product);

        Task<bool> UpdateProduct(int id, Product Product);

        Task<bool> DeleteProduct(int id);
    }
}
