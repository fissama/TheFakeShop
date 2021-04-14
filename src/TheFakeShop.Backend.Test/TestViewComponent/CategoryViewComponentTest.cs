using Microsoft.AspNetCore.Mvc;
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

        public CategoryViewComponentTest(SqliteInMemoryFixture fixture)
        {
            _fixture = fixture;
            _fixture.CreateDatabase();
            var dbContext = _fixture.Context;
            var category = new CategoryPostRequest { Name = "Test category" };

            var controller = new CategoriesController(dbContext);
            var result = controller.PostCategory(category);
        }

        [Fact]
        public async Task PostCategory_Success()
        {
            var categoryMenu = new CategoryMenuViewComponent(_fixture.CategoryApiClient);
            var result = categoryMenu.InvokeAsync();
            var createdAtActionResult = Assert.IsType<IViewComponentResult>(result);
          /*  var returnValue = Assert.IsType<CategoryViewModel>(createdAtActionResult.Value);*/
           // Assert.Equal();
        }
    }
}
