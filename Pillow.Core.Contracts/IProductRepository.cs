using Pillow.Core.Entites;
using System;
using System.Collections.Generic;

namespace Pillow.Core.Contracts
{
    public interface IProductRepository
    {
        Product Get(int ProductId);
        (List<Product>, int Count) GetFilterProducts(string search, string category, int pageNumber, int PageSize);
        List<Product> GetChippestProduct();
        List<Product> GetNewstProduct();
    }
}
