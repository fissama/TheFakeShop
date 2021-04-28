using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;
using TheFakeShop.Backend.Services;
using TheFakeShop.ShareModels;

namespace TheFakeShop.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ProductViewModel>>> GetProducts()
        {
            /* var products = await _context.Products.Include("ProductImages").Select(x =>
                 new
                 {
                     x.ProductId,
                     x.ProductName,
                     x.Price,
                     x.Description,
                     x.ProductImages
                 }).ToListAsync();*/

            var products = await _productService.ReadAllProduct();

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

        [HttpGet("CategoryId={id}")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ProductViewModel>>> GetProductsByCategoryId(int id)
        {
            /*var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            //var products = await _context.Products.Include("ProductImages").ToListAsync();
            if (category.ParentId == null)
            {
                var childCategories = await _context.Categories.Where(x => x.ParentId == id).Select(x => x.CategoryId).ToListAsync();

                var products = await _context.Products.Include("ProductImages").Where(x => childCategories.Contains((int)x.CategoryId))
                .Select(x =>
                new
                {
                    x.ProductId,
                    x.ProductName,
                    x.Price,
                    x.Description,
                    x.ProductImages
                }).ToListAsync();

                *//*    var products = _productService.ReadProductByCategoryId(id);*//*

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
            else
            {
                var products = await _context.Products.Include("ProductImages").Where(x => x.CategoryId == id)
                .Select(x =>
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
            }*/
            var products = await _productService.ReadProductByCategoryId(id);
            if(products==null)
            {
                return NotFound();
            }
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
            var getProduct = await _productService.ReadProductById(id);
            if (getProduct == null)
            {
                return NotFound();
            }
            var ratings = getProduct.ProductRatings.ToList();
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
                ProductId = getProduct.ProductId,
                ProductName = getProduct.ProductName,
                Price = getProduct.Price,
                InStock = getProduct.InStock,
                Description = getProduct.Description,
                CategoryId = getProduct.CategoryId,
                ProductImages = getProduct.ProductImages.Select(x => x.ImageLink).ToList(),
                ratingViewModels = temp
            };
            return prodVM;
        }

        [HttpPost]
        public async Task<IActionResult> PostProduct([FromForm] ProductCreateRequest productCreateRequest)
        {
            /*var category = await _context.Categories.FindAsync(productCreateRequest.CategoryId);

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

            return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, null);*/
            var postProduct = new Product
            {
                ProductName = productCreateRequest.Name,
                Description = productCreateRequest.Description,
                Price = productCreateRequest.Price,
                InStock = productCreateRequest.Instock,
                CategoryId = productCreateRequest.CategoryId
            };
            foreach(var el in productCreateRequest.Images)
            {
                postProduct.ProductImages.Add(new ProductImage
                {
                    ImageLink = el,
                    ProductId = 0
                });
            }
            var isPostSuccessProduct = await _productService.CreateProduct(postProduct);


            if (isPostSuccessProduct)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, ProductCreateRequest productCreateRequest)
        {
            /*var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            foreach (var el in _context.ProductImages.Where(x => x.ProductId == product.ProductId))
            {
                _context.ProductImages.Remove(el);
            }
            await _context.SaveChangesAsync();
            foreach (var el in prodRequest.Images)
            {
                if (el != "")
                {
                    _context.ProductImages.Add(new ProductImage
                    {
                        ProductId = product.ProductId,
                        ImageLink = el
                    });
                }
            }
            await _context.SaveChangesAsync();
            product.ProductName = prodRequest.Name;
            product.Price = prodRequest.Price;
            product.Description = prodRequest.Description;
            product.InStock = prodRequest.Instock;
            await _context.SaveChangesAsync();*/
            var putProduct = new Product
            {
                ProductName = productCreateRequest.Name,
                Description = productCreateRequest.Description,
                Price = productCreateRequest.Price,
                InStock = productCreateRequest.Instock,
                CategoryId = productCreateRequest.CategoryId
            };
            foreach (var el in productCreateRequest.Images)
            {
                putProduct.ProductImages.Add(new ProductImage
                {
                    ImageLink = el,
                    ProductId = id
                });
            }
            var isPutSuccessCategory = await _productService.UpdateProduct(id, putProduct);

            if (isPutSuccessCategory)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var isDeleteSuccessProduct = await _productService.DeleteProduct(id);

            if (isDeleteSuccessProduct)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
