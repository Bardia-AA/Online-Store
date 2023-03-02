using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pillow.Core.ApplicationService;
using Pillow.Core.Contracts;
using Pillow.Core.Entites;

namespace PresentationHost.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly Cart cart;
        private readonly IOrderService orderService;

        public CheckoutController(Cart cart, IOrderService orderService)
        {
            this.cart = cart;
            this.orderService = orderService;
        }
        public IActionResult Index()
        {
            ViewBag.cart = cart;
            return View(new Order());
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Index(Order order)
        {
            var totalPice = cart.GetTotalPrice();
            if (cart.CartLines.Count() == 0)
            {
                ModelState.AddModelError("", "سفارشی موجود نیست");
            }

            if (ModelState.IsValid)
            {
                order.Lines = cart.CartLines.ToList();
                orderService.SaveOrder(order);
                cart.Clear();
                return RedirectToAction("Pay", "Payment", new { orderId = order.OrderID, totalPrice = totalPice });
            }
            return View(order);
        }
public IActionResult confirmation()
        {
            return View();
        }
    }
}