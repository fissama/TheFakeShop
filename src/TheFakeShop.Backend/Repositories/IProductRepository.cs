using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;

namespace TheFakeShop.Backend.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ReadAllProduct();

        Task<Product> ReadProductById(int id);

        Task<bool> CreateProduct(Product Product);

        Task<bool> UpdateProduct(int id, Product Product);

        Task<bool> DeleteProduct(int id);

        Task<bool> FindById(int id);
    }
}
