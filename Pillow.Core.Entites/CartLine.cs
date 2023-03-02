using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Pillow.Core.Entites
{
  
    public class CartLine
    {
      public int CartLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
