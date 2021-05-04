using System.ComponentModel.DataAnnotations;

namespace TheFakeShop.ShareModels
{
    public class CategoryPostRequest
    {
        [Required]
        public string Name { get; set; }

        public int parentId { get; set; }
    }
}
