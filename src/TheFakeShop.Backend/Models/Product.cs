using System;
using System.Collections.Generic;

#nullable disable

namespace TheFakeShop.Backend.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ProductImages = new HashSet<ProductImage>();
            ProductRatings = new HashSet<ProductRating>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public int? InStock { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductRating> ProductRatings { get; set; }
    }
}
