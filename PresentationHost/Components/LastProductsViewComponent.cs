using Microsoft.AspNetCore.Mvc;
using Pillow.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationHost.Components
{
    public class LastProductsViewComponent: ViewComponent
    {
        private readonly IProdctService productRepository;

        public LastProductsViewComponent(IProdctService productRepository)
        {
            this.productRepository = productRepository;
        }
        public IViewComponentResult Invoke()
        {
            var data = productRepository.GetNewestProduct().ToList();
            return View(data);
        }
    }
}
