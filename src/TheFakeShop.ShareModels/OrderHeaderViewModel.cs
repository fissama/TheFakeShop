using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFakeShop.ShareModels
{
    public class OrderHeaderViewModel
    {
        public int OrderId { get; set; }
        public string Phone { get; set; }
        public string CustomerEmail { get; set; }
        public decimal? Cost { get; set; }
        public string FullAddress { get; set; }
        public DateTime CreatedAt { get; set; }
        public string OrderStatus { get; set; }
        public IList<OrderDetailViewModel> orderDetail { get; set; }
    }
}
