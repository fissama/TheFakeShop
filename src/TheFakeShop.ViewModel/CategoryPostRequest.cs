using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheFakeShop.ViewModel
{
    public class CategoryPostRequest
    {
        [Required]
        public string Name { get; set; }

        public int parentId { get; set; }
    }
}
