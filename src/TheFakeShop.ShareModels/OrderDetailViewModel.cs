using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFakeShop.ShareModels
{
    public class OrderDetailViewModel
    {
        public int? Qty { get; set; }

        public int? ProductId { get; set; }

        public int? OrderId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }
    }
}
