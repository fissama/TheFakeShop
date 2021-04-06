using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheFakeShop.ShareModels
{
    class ProductViewModel
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal? Price { get; set; }

        public int? InStock { get; set; }

        public string Description { get; set; }

        public IList<string> ProductImages  { get; set; }
    }
}
