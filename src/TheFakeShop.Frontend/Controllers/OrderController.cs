using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Frontend.Services;
using TheFakeShop.ShareModels;

namespace TheFakeShop.Frontend.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderApiClient _orderApiClient;
        private readonly IProductApiClient _productApiClient;

        public OrderController (IOrderApiClient orderApiClient,IProductApiClient productApiClient)
        {
            _orderApiClient = orderApiClient;
            _productApiClient = productApiClient;
        }

        [Route("/order")]
        public async Task<IActionResult> Index()
        {
            var result = await _orderApiClient.GetHistoryOrder(User.Identity.Name);
           
            return View(result);
        }

        [Route("/order/{id}")]
        public async Task<IActionResult> OrderDetail(int id)
        {
            var result = await _orderApiClient.GetOrderById(id);
            foreach (var el in result.orderDetail)
            {
                var tempProduct = await _productApiClient.GetProductById((int)el.ProductId);
                el.Image = tempProduct.ProductImages[0];
                el.Price = (decimal)tempProduct.Price;
                el.ProductName = tempProduct.ProductName;
            }    
            return View(result);
        }
    }
}
