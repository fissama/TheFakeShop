using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFakeShop.ShareModels
{
    public class ProductCreateRequest
    {
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public int Instock { get; set; }

        public int CategoryId { get; set; }

        public IList<string> Images { get; set; }
    }
}
