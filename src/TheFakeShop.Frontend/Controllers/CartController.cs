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
            return RedirectToAction("Index","Cart");
        }
    }
}
