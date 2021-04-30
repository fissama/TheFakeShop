using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFakeShop.ShareModels
{
    public class CartItemViewModel
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int Qty { get; set; }

        public string Image { get; set; }
    }
}
