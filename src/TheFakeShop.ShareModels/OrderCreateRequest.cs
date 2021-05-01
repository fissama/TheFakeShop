using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFakeShop.ShareModels
{
    public class OrderCreateRequest
    {
        [Required]
        public string CustomerEmail { get; set; }

        public string Phone { get; set; }

        public decimal? Cost { get; set; }

        public string FullAddress { get; set; }

        public DateTime CreatedAt { get; set; }

        public string OrderStatus { get; set; }

        public IList<OrderDetailViewModel> orderDetail { get; set; }
    }
}
