using System;
using System.Collections.Generic;

#nullable disable

namespace TheFakeShop.Backend.Models
{
    public partial class ProductImage
    {
        public int PimageId { get; set; }
        public string ImageLink { get; set; }
        public int? ProductId { get; set; }
        public byte[] ModifiedAt { get; set; }

        public virtual Product Product { get; set; }
    }
}
