using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheFakeShop.Frontend.Services;
using TheFakeShop.Frontend.ViewComponents;
using TheFakeShop.ShareModels;
using Xunit;

namespace TheFakeShop.Test.FrontendTest.TestViewComponents
{
    public class CategoryViewComponentTest
    {
        [Fact]
        public async Task getCategoryViewComponent_Success()
        {
            //Arrange View Component
            var httpContext = new DefaultHttpContext();
            var viewContext = new ViewContext();
            viewContext.HttpContext = httpContext;
            var viewComponentContext = new ViewComponentContext();
            viewComponentContext.ViewContext = viewContext;

            //Arrange Mock Client
            var categoryApiClientMock = new Mock<ICategoryApiClient>();
            categoryApiClientMock.Setup(c => c.GetCategories()).Returns(getCategoriesValue());
            var viewComponent = new CategoryMenuViewComponent(categoryApiClientMock.Object);

            //Act - Check final result is viewcomponent
            var result = viewComponent.InvokeAsync();
            var createdAtActionResult = await Assert.IsType<Task<IViewComponentResult>>(result);
        }

        private Task<IList<CategoryViewModel>> getCategoriesValue()
        {
            IList<CategoryViewModel> categoriesValue = new List<CategoryViewModel>();
            return Task.FromResult(categoriesValue);
        }
    }
}
