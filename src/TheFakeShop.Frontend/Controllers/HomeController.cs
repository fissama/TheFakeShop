using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Frontend.Models;
using TheFakeShop.Frontend.Services;

namespace TheFakeShop.Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductApiClient _productClient;

        public HomeController(ILogger<HomeController> logger, IProductApiClient productClient)
        {
            _logger = logger;
            _productClient = productClient;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productClient.GetProducts();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
