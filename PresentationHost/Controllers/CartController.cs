using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pillow.Core.Contracts;
using Pillow.Core.Entites;

namespace PresentationHost.Controllers
{
    public class CartController : Controller
    {
        private readonly IProdctService prodctService;
        private readonly Cart cart;

        public CartController(IProdctService prodctService, Cart cart)
        {
            this.prodctService = prodctService;
            this.cart = cart;
        }
        public IActionResult Index()
        {
            return View(cart);
        }

        //[HttpPost]
        //public IActionResult Index(int productId)
        //{
        //    cart.RemoveLine(productId);
        //    return View(cart);
        //}

        //[HttpPost]
        //public IActionResult RemoveFromCart(int productId)
        //{
        //    cart.RemoveLine(productId);
        //    return View("~/Views/Cart/Index.cshtml", cart);

        //}
        [HttpPost]
        public IActionResult Index(int productId, int quantity, int finalPrice, string action)
        {
            if (action == "remove")
            {
                cart.RemoveLine(productId);
            }
            else
            {
                cart.UpdateQuantity(productId, quantity);
                return View(cart);
            }
            return View(cart);
        }


        //[HttpPost]
        //public IActionResult Index(int productId, int quantity, decimal finalPrice)
        //{
        //    cart.UpdateQuantity(productId, quantity);
        //    return View(cart);
        //}


        public IActionResult AddToCart(int productId, int qunaity)
        {
            string referer = Request.Headers["Referer"].ToString();
            Product product = prodctService.Get(productId);
            if (product != null)
            {
                cart.AddItem(product, qunaity);
            }
            return Redirect(referer);
        }
    }
}