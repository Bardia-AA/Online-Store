using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pillow.Core.Contracts;
using Pillow.Core.Entites;
using PresentationHost.Models;

namespace PresentationHost.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IOrderService orderService;
        private readonly IPayment payment;

        public PaymentController(IOrderService orderService, IPayment payment)
        {
            this.payment = payment;
            this.orderService = orderService;
        }
        public IActionResult Pay(int orderId, int totalPrice)
        {
            var result = payment.pay(totalPrice.ToString());
            if (result.Status == 1)
            {
                orderService.SetTransactionId(orderId, result.Token);
                return Redirect("https://pay.ir/pg/" + result.Token);
            }
            return View();
        }

        public IActionResult Verify(PaymentResponseViewModel model)
        {
            if (model.status == 1)
            {
                VerifyPayment verifyResult = payment.Verify(model.token.ToString());
                if (verifyResult.Status == 1)
                {
                    orderService.PaymentDone(model.token, verifyResult.transId);
                    return Content($"پرداخت با موفقیت انجام شد شماره پیگیری {verifyResult.transId}");
                }


            }
            return View(model);
        }
    }
}