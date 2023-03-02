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
    public class ProductController : Controller
    {
        private readonly IProdctService productService;

        public ProductController(IProdctService productService)
        {
            this.productService = productService;
        }
        public IActionResult Search(int page = 1, string category = "All", string q = "")
        {
            var data = productService.ProductSearch(q, category, page, 4);
            PagedList<Product> pageList = new PagedList<Product>(data.Item1, page, 4, data.Item2);
            ViewBag.category = category;
            ViewBag.q = q;

            return View(pageList);
        }

        public IActionResult Detail(int id)
        {

            Product product = productService.Get(id);
            return View(product);
        }
    }
}