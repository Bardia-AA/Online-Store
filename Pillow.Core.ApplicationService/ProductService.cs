using Pillow.Core.Contracts;
using Pillow.Core.Entites;
using System.Collections.Generic;
using System.Linq;

namespace Pillow.Core.ApplicationService
{
    public class ProductService : IProdctService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public List<Product> GetChippestProduct()
        {
            return productRepository.GetChippestProduct()
                 .Take(4).ToList();
        }

        public List<Product> GetNewestProduct()
        {
            return productRepository.GetNewstProduct();
        }

        public (List<Product>, int) ProductSearch(string q, string category, int pageNumber, int PageSize)
        {
            return productRepository.GetFilterProducts(q, category, pageNumber, PageSize);
        }


        public Product Get(int ProductId)
        {
            return productRepository.Get(ProductId);
        }
    }
}
