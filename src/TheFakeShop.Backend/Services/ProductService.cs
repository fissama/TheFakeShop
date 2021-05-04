using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;
using TheFakeShop.Backend.Repositories;

namespace TheFakeShop.Backend.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductService(IProductRepository ProductRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = ProductRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Product>> ReadAllProduct()
        {
            return await _productRepository.ReadAllProduct();
        }

        public async Task<IEnumerable<Product>> ReadSearchProducts(string searchContent)
        {
            return await _productRepository.ReadSearchProducts(searchContent);
        }

        public async Task<IEnumerable<Product>> ReadProductByCategoryId(int id)
        {
            var hasCategory = await _categoryRepository.FindById(id);
            if (hasCategory)
            {
                var category = await _categoryRepository.ReadCategoryById(id);
                if (category.ParentId == null)
                {
                    var childCategory = (await _categoryRepository.ReadAllCategory()).Where(x => x.ParentId == category.CategoryId).Select(x=>x.CategoryId).ToList();
                    var allProductByCategoryId = (await _productRepository.ReadAllProduct()).Where(x => childCategory.Contains((int)x.CategoryId));
                    return allProductByCategoryId;
                }
                else
                {
                    var allProductByCategoryId = (await _productRepository.ReadAllProduct()).Where(x => x.CategoryId == id);
                    return allProductByCategoryId;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<Product> ReadProductById(int id)
        {
            if (await _productRepository.FindById(id))
            {
                return await _productRepository.ReadProductById(id);
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> CreateProduct(Product product)
        {
            if(await _categoryRepository.FindById((int)product.CategoryId))
            {
                if (await _productRepository.CreateProduct(product))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProduct(int id, Product Product)
        {
            if (await _productRepository.FindById(id))
            {
                return await _productRepository.UpdateProduct(id, Product);
            }
            else 
            { 
                return false;
            }
        }

        public async Task<bool> DeleteProduct(int id)
        {
            if (await _productRepository.FindById(id))
            {
                return await _productRepository.DeleteProduct(id);
            }
            else
            {
                return false;
            }
        }
    }
}
