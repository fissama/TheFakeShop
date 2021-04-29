using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFakeShop.Backend.Controllers;
using TheFakeShop.Backend.Services;
using TheFakeShop.ShareModels;
using Xunit;

namespace TheFakeShop.Test.BackendTest.TestController
{
    public class CategoryControllerTest
    {
        private CategoriesController categoryController = new CategoriesController(new Mock<ICategoryService>().Object);

        [Fact]
        public async Task getAllCategory_Success()
        {
            //Act - Check final result
            var result = categoryController.GetCategories();
            var createdAtActionResult = await Assert.IsType<Task<ActionResult<IEnumerable<CategoryViewModel>>>>(result);
        }

        [Fact]
        public async Task getCategoryById_Success()
        {
            //Act - Check final result
            var result = categoryController.GetCategory(1);
            var createdAtActionResult = await Assert.IsType<Task<ActionResult<CategoryViewModel>>>(result);
        }

        [Fact]
        public async Task postCategory_Success()
        {
            //Act - Check final result
            var result = categoryController.PostCategory(new CategoryPostRequest { Name = "Test demo 02"});
            var createdAtActionResult = await Assert.IsType<Task<ActionResult<CategoryViewModel>>>(result);
        }

        [Fact]
        public async Task putCategory_Success()
        {
            //Act - Check final result
            var result = categoryController.PutCategory(1, new CategoryPostRequest { Name = "Test demo 02" });
            var createdAtActionResult = await Assert.IsType<Task<IActionResult>>(result);
        }

        [Fact]
        public async Task DeleteCategory_Success()
        {
            //Act - Check final result
            var result = categoryController.DeleteCategory(1);
            var createdAtActionResult = await Assert.IsType<Task<IActionResult>>(result);
        }
    }
}
