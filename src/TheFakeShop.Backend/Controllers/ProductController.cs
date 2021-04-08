using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;
using TheFakeShop.ShareModels;

namespace TheFakeShop.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly TheFakeShopContext _context;

        public ProductController(TheFakeShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ProductViewModel>>> GetProducts()
        {
            var products = await _context.Products.Include("ProductImages").Select(x =>
                new
                {
                    x.ProductId,
                    x.ProductName,
                    x.Price,
                    x.Description,
                    x.ProductImages
                }).ToListAsync();



            var prodVMs = products.Select(x =>
                new ProductViewModel
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    Price = x.Price,
                    Description = x.Description,
                    ProductImages = x.ProductImages.Select(x => x.ImageLink).ToList()
                }).ToList();

            return prodVMs;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ProductViewModel>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            product = await _context.Products.Include("ProductImages").Include("ProductRatings").Where(x => x.ProductId == id).FirstAsync();
            var ratings = product.ProductRatings.ToList();
            IList<RatingViewModel> temp = new List<RatingViewModel>();
            foreach(var el in ratings)
            {
                temp.Add(new RatingViewModel
                {
                    CustomerName = el.CustomerName,
                    CustomerEmail = el.CustomerEmail,
                    PratingId = el.PratingId,
                    Rating = el.Rating,
                    Title = el.Title,
                    Content = el.Content
                });
            }
            var prodVM = new ProductViewModel
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Price = product.Price,
                InStock = product.InStock,
                Description = product.Description,
                ProductImages = product.ProductImages.Select(x => x.ImageLink).ToList(),
                ratingViewModels = temp
            };
            return prodVM;
        }

        [HttpPost]
        public async Task<IActionResult> PostProduct([FromForm] ProductCreateRequest productCreateRequest)
        {
            var category = await _context.Categories.FindAsync(productCreateRequest.CategoryId);

            if (category == null)
            {
                return NotFound();
            }
            var product = new Product
            {
                ProductName = productCreateRequest.Name,
                Description = productCreateRequest.Description,
                Price = productCreateRequest.Price,
                InStock = productCreateRequest.Instock,
                CategoryId = category.CategoryId
            };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            product = _context.Products.OrderByDescending(s=>s.ProductId).FirstOrDefault();
            foreach(var el in productCreateRequest.Images)
            {
                _context.ProductImages.Add(new ProductImage
                {
                    ProductId = product.ProductId,
                    ImageLink = el
                });
            }    
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, null);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, ProductCreateRequest prodRequest)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            product.ProductName = prodRequest.Name;
            product.Price = prodRequest.Price;
            product.Description = prodRequest.Description;
            product.InStock = prodRequest.Instock;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            foreach(var el in _context.ProductRatings.Where(x=>x.ProductId==product.ProductId))
            {
                _context.ProductRatings.Remove(el);
            }
            await _context.SaveChangesAsync();

            foreach (var el in _context.ProductImages.Where(x => x.ProductId == product.ProductId))
            {
                _context.ProductImages.Remove(el);
            }
            await _context.SaveChangesAsync();

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
