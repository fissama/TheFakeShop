using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFakeShop.ShareModels
{
    public class RatingCreateRequest
    {
        [Required]
        public int PratingId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }

        public byte? Rating { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int? ProductID { get; set; }
    }
}
