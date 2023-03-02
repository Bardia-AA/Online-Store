using Pillow.Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pillow.Core.Contracts
{
    public interface IProdctService
    {
        Product Get(int ProductId);
        (List<Product>, int) ProductSearch(string q, string category, int pageNumber, int PageSize);

        List<Product> GetChippestProduct();
        List<Product> GetNewestProduct();
    }
}
