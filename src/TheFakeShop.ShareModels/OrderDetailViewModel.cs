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
    }
}
