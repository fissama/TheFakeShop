using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace TheFakeShop.Service.Product.Services
{
    public class CategoryService : Category.CategoryBase
    {
        public override Task<GetAllCategoryResponse> GetAllCategory(Empty request, ServerCallContext context)
        {
            var response = new GetAllCategoryResponse();
            response.Categories.Add(new GetCategoryResponse { CategoryId = 1, CategoryName = "demo", CreatedAt = Timestamp.FromDateTime(DateTime.Now) });
            return Task.FromResult(response);
        }

        public override Task<GetCategoryResponse> GetCategory(GetCategoryRequest request, ServerCallContext context)
        {
            var category = new GetCategoryResponse { CategoryId=1,CategoryName="demo",CreatedAt=Timestamp.FromDateTime(DateTime.Now)};
            
            return Task.FromResult(category);
        }
    }
}
