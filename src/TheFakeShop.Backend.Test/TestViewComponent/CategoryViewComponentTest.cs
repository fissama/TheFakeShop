using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFakeShop.Backend.Controllers;
using TheFakeShop.Frontend.Services;
using TheFakeShop.Frontend.ViewComponents;
using TheFakeShop.ShareModels;
using Xunit;

namespace TheFakeShop.Backend.Test.TestViewComponent
{
    public class CategoryViewComponentTest : IClassFixture<SqliteInMemoryFixture>
    {
        private readonly SqliteInMemoryFixture _fixture;
        private readonly CategoryMenuViewComponent _categoryMenu;

        public CategoryViewComponentTest(SqliteInMemoryFixture fixture)
        {
            _fixture = fixture;
            _fixture.CreateDatabase();
            var dbContext = _fixture.Context;
            var category = new CategoryPostRequest { Name = "Test category" };

            var controller = new CategoriesController(dbContext);
            var result = controller.PostCategory(category);
            var mock = new Mock<ICategoryApiClient>();
            _categoryMenu = new CategoryMenuViewComponent(mock.Object);
        }

        [Fact]
        public async Task GetCategory_Success()
        {
            var result = await _categoryMenu.InvokeAsync();
            var action = ((ViewViewComponentResult)result);
            var actionResult = action.ViewData;
            /*var createdAtActionResult = Assert.IsType<IViewComponentResult>(result);
            var returnValue = Assert.IsType<CategoryViewModel>(createdAtActionResult);*/
           // Assert.Equal();
        }
    }
}
