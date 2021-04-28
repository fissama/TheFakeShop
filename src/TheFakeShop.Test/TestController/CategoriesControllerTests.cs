using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Controllers;
using TheFakeShop.Backend.Models;
using TheFakeShop.ShareModels;
using Xunit;

namespace TheFakeShop.Backend.Test.TestController
{
    public class CategoriesControllerTests : IClassFixture<SqliteInMemoryFixture>
    {
        private readonly SqliteInMemoryFixture _fixture;

        public CategoriesControllerTests(SqliteInMemoryFixture fixture)
        {
            _fixture = fixture;
            _fixture.CreateDatabase();
        }

        [Fact]
        public async Task PostCategory_Success()
        {
            var dbContext = _fixture.Context;
            var category = new CategoryPostRequest { Name = "Test category" };

            var controller = new CategoriesController(dbContext);
            var result = await controller.PostCategory(category);

            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result.Result);
            var returnValue = Assert.IsType<CategoryViewModel>(createdAtActionResult.Value);
            Assert.Equal("Test category", returnValue.CategoryName);
        }

        [Fact]
        public async Task PutCategory_Success()
        {
            var dbContext = _fixture.Context;
            dbContext.Categories.Add(new Category { CategoryName = "Test category" });
            await dbContext.SaveChangesAsync();

            var oldCategory = await dbContext.Categories.OrderByDescending(x => x.CategoryId).FirstAsync();
            var category = new CategoryPostRequest { Name = "Test put category" };

            var controller = new CategoriesController(dbContext);
            var result = await controller.PutCategory(oldCategory.CategoryId,category);

            var returnValue = await dbContext.Categories.OrderByDescending(x => x.CategoryId).FirstAsync();
            Assert.Equal("Test put category", returnValue.CategoryName);
        }

        [Fact]
        public async Task DeleteCategory_Success()
        {
            var dbContext = _fixture.Context;
            dbContext.Categories.Add(new Category { CategoryName = "Test category" });
            await dbContext.SaveChangesAsync();

            var oldCategory = await dbContext.Categories.OrderByDescending(x => x.CategoryId).FirstAsync();

            var controller = new CategoriesController(dbContext);
            var result = await controller.DeleteCategory(oldCategory.CategoryId);

            var returnValue = await dbContext.Categories.ToListAsync();
            Assert.Empty(returnValue);
        }

        [Fact]
        public async Task GetCategory_Success()
        {
            var dbContext = _fixture.Context;
            dbContext.Categories.Add(new Category { CategoryName = "Test category" });
            await dbContext.SaveChangesAsync();

            var controller = new CategoriesController(dbContext);
            var result = await controller.GetCategories();

            var actionResult = Assert.IsType<ActionResult<IEnumerable<CategoryViewModel>>>(result);
            Assert.NotEmpty(actionResult.Value);
        }
    }
}
