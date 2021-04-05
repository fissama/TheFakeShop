namespace TheFakeShop.ShareModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }
        
        public int? parentId { get; set; }
    }
}