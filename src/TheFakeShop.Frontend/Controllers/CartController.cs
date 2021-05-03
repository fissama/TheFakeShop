using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Frontend.Services;
using TheFakeShop.ShareModels;

namespace TheFakeShop.Frontend.Controllers
{
    public class CartController : Controller
    {
        private readonly IOrderApiClient _orderApiClient;

        public CartController(IOrderApiClient orderApiClient)
        {
            _orderApiClient = orderApiClient;
        }

        [Route("/cart")]
        public IActionResult Index()
        {
            var result = HttpContext.Session.Get<List<CartItemViewModel>>("UserCart");
            if (result == null)
            {
                result = new List<CartItemViewModel>();
            }
            return View(result);
        }

        public IActionResult Delete(int id)
        {
            List<CartItemViewModel> cart = HttpContext.Session.Get<List<CartItemViewModel>>("UserCart");

            var deleteMe = cart.Find(x => x.ProductId == id);

            cart.Remove(deleteMe);
            HttpContext.Session.Set("UserCart", cart);
            Task.WaitAll(Task.Delay(2000));
            return RedirectToAction("Index","Cart");
        }

        public async Task<IActionResult> AddOrder(string phone, string fullAddress,string customerEmail)
        {
            List<CartItemViewModel> cart = HttpContext.Session.Get<List<CartItemViewModel>>("UserCart");
            var orderVM = new OrderCreateRequest { 
                Phone = phone,
                FullAddress = fullAddress,
                CustomerEmail = customerEmail,
                Cost = 0,
                OrderStatus = "XN",
                orderDetail=new List<OrderDetailViewModel>()
            };
            foreach(var el in cart)
            {
                orderVM.Cost += el.Price * el.Qty;
                orderVM.orderDetail.Add(new OrderDetailViewModel { Qty = el.Qty, ProductId = el.ProductId });
            }
            var result = await _orderApiClient.addOrder(orderVM);
            if (result)
            {
                Task.WaitAll(Task.Delay(2000));
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Task.WaitAll(Task.Delay(2000));
                return RedirectToAction("Index", "Cart");
            }
        }

    }
}
