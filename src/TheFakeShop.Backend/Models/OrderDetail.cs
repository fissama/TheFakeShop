using System;
using System.Collections.Generic;

#nullable disable

namespace TheFakeShop.Backend.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? Qty { get; set; }
        public int? ProductId { get; set; }
        public int? OrderId { get; set; }

        public virtual OrderHeader Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
