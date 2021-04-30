using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Frontend.Services;
using TheFakeShop.ShareModels;
using Hanssens.Net;

namespace TheFakeShop.Frontend.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;


        public ProductController(IProductApiClient productApiClient)
        {
            _productApiClient = productApiClient;

        }

        [Route("/product/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var result = await _productApiClient.GetProductById(id);
            return View(result);
        }

        [Route("/category/{id}")]
        public async Task<IActionResult> ProductByCategory(int id)
        {
            var result = await _productApiClient.GetProductsByCategoryId(id);
            return View(result);
        }

        [HttpPost("[controller]/{id}")]
        public async Task<IActionResult> Rating(string CustomerName, string CustomerEmail, byte Rating, string Title, string Content, int ProductID)
        {
            RatingCreateRequest ratingCreate = new()
            {
                CustomerName = CustomerName,
                CustomerEmail = CustomerEmail,
                Rating = Rating,
                Title = Title,
                Content = Content,
                ProductID = ProductID
            };

            var result = await _productApiClient.Rating(ratingCreate);

            if (!result)
            {
                return NoContent();
            }

            return RedirectToAction("Details","Product",new { id=ProductID}); //????
        }

        public async Task<IActionResult> addProductToCart(int id, int qty)
        {
            List<CartItemViewModel> cart = HttpContext.Session.Get<List<CartItemViewModel>>("UserCart");
            if(cart==null)
            {
                cart = new List<CartItemViewModel>();
            }

            foreach (var item in cart)
            {
                if (item.ProductId == id)
                {
                    item.Qty += qty;
                    HttpContext.Session.Set<List<CartItemViewModel>>("UserCart",cart);
                    return RedirectToAction("Details", "Product", new { id = id });
                }
            }

            var product = await _productApiClient.GetProductById(id);
            var productItem = new CartItemViewModel
            {
                ProductId = (int)product.ProductId,
                ProductName = product.ProductName,
                Price = (decimal)product.Price,
                Qty = qty,
                Image = product.ProductImages[0]
            };

            cart.Add(productItem);
            HttpContext.Session.Set<List<CartItemViewModel>>("UserCart", cart);

            return RedirectToAction("Details", "Product", new { id = id });
        }

    }
}
