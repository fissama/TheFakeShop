using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;

namespace TheFakeShop.Backend.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly TheFakeShopContext _context;

        public ProductRepository(TheFakeShopContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> ReadAllProduct()
        {
            return await _context.Products.Include(x=>x.ProductImages).ToListAsync();
        }

        public async Task<Product> ReadProductById(int id)
        {
            return await _context.Products.Include(x=>x.ProductImages).Include(x=>x.ProductRatings).Where(x => x.ProductId == id).FirstAsync();
        }

        public async Task<bool> CreateProduct(Product product)
        {
            _context.Add(product);
            if (await _context.SaveChangesAsync() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProduct(int id,Product product)
        {
            var productOld = await _context.Products.FindAsync(id);
            foreach (var el in _context.ProductImages.Where(x => x.ProductId == productOld.ProductId))
            {
                _context.ProductImages.Remove(el);
            }
            await _context.SaveChangesAsync();
            foreach (var el in product.ProductImages)
            {
                if (el.ImageLink != "")
                {
                    _context.ProductImages.Add(el);
                }
            }
            await _context.SaveChangesAsync();
            productOld.ProductName = product.ProductName;
            productOld.Price = product.Price;
            productOld.Description = product.Description;
            productOld.InStock = product.InStock;
            productOld.InStock = product.CategoryId;
            if (await _context.SaveChangesAsync() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var ProductOld = await _context.Products.FindAsync(id);
            foreach (var el in _context.ProductRatings.Where(x => x.ProductId == ProductOld.ProductId))
            {
                _context.ProductRatings.Remove(el);
            }
            await _context.SaveChangesAsync();

            foreach (var el in _context.ProductImages.Where(x => x.ProductId == ProductOld.ProductId))
            {
                _context.ProductImages.Remove(el);
            }
            await _context.SaveChangesAsync();

            _context.Products.Remove(ProductOld);
            if (await _context.SaveChangesAsync() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> FindById(int id)
        {
            var findProduct = await _context.Products.FindAsync(id);
            if (findProduct == null)
            {
                return false;
            }
            var isProductFound = (findProduct.ProductId == id);
            return isProductFound;
        }
    }
}
