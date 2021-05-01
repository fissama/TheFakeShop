using System;
using System.Collections.Generic;

#nullable disable

namespace TheFakeShop.Backend.Models
{
    public partial class OrderHeader
    {
        public OrderHeader()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public string Phone { get; set; }
        public string CustomerEmail { get; set; }
        public decimal? Cost { get; set; }
        public string FullAddress { get; set; }
        public DateTime CreatedAt { get; set; }
        public string OrderStatus { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
