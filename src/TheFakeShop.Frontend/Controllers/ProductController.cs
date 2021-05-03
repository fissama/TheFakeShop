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
        private readonly ICategoryApiClient _categoryApiClient;

        public ProductController(IProductApiClient productApiClient,ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;

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
            ViewBag.CategoryName = _categoryApiClient.GetCategories().Result.Where(x=>x.Id==id).Select(x=>x.CategoryName).First();
            return View(result);
        }

        [HttpPost("[controller]/{id}")]
        public Task<IActionResult> GetMenuItems(string isRating,string CustomerName, string CustomerEmail, byte Rating, string Title, string Content, int ProductID,int qty) =>
        isRating == "true" ? addRating(CustomerName, CustomerEmail, Rating, Title, Content, ProductID) : addProductToCart(ProductID, qty);

        private async Task<IActionResult> addRating(string CustomerName, string CustomerEmail, byte Rating, string Title, string Content, int ProductID)
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
                Task.WaitAll(Task.Delay(2000));
                return NoContent();
            }
            Task.WaitAll(Task.Delay(2000));
            return RedirectToAction("Details","Product",new { id=ProductID}); //????
        }

        private async Task<IActionResult> addProductToCart(int id, int qty)
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
                    Task.WaitAll(Task.Delay(2000));
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

            Task.WaitAll(Task.Delay(2000));
            return RedirectToAction("Details", "Product", new { id = id });
        }

    }
}
