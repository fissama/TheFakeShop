using System;
using System.Collections.Generic;

#nullable disable

namespace TheFakeShop.Backend.Models
{
    public partial class ProductRating
    {
        public int PratingId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public byte? Rating { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? ProductId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Product Product { get; set; }
    }
}
