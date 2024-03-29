﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheFakeShop.ShareModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal? Price { get; set; }

        public int? InStock { get; set; }

        public string Description { get; set; }

        public int? CategoryId { get; set; }

        public IList<string> ProductImages  { get; set; }

        public IList<RatingViewModel> ratingViewModels { get; set; }
    }
}
