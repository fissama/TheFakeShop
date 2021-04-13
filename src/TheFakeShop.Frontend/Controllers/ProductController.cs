using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Frontend.Services;
using TheFakeShop.ShareModels;

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
            RatingCreateRequest ratingCreate = new RatingCreateRequest
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

    }
}
