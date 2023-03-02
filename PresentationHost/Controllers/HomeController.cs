using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pillow.Core.Contracts;
using PresentationHost.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationHost.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdctService productService;

        public HomeController(IProdctService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult about()
        {
            return View();
        }

        public IActionResult blog()
        {
            return View();
        }

        public IActionResult single_blog()
        {
            return View();
        }

        public IActionResult contact()
        {
            return View();
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
