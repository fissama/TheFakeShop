using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFakeShop.ShareModels
{
    public class RatingViewModel
    {
        public int PratingId { get; set; }
    
        public string CustomerName { get; set; }
        
        public string CustomerEmail { get; set; }
        
        public byte? Rating { get; set; }
        
        public string Title { get; set; }
        
        public string Content { get; set; }

        public int? ProductID { get; set; }
    }
}
