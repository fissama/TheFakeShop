using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;
using TheFakeShop.Backend.Repositories;
using TheFakeShop.Backend.Services;
using Xunit;

namespace TheFakeShop.Test.BackendTest.TestServices
{
    public class CategoryServiceTest
    {
        private CategoryService categoryService = new CategoryService(new Mock<ICategoryRepository>().Object);

        [Fact]
        public async Task ReadAllCategory_Success()
        {
            //Act - Check final result
            var result = categoryService.ReadAllCategory();
            var createdAtActionResult = await Assert.IsType<Task<IEnumerable<Category>>>(result);
        }

        [Fact]
        public async Task ReadCategoryById_Success()
        {
            //Act - Check final result
            var result = categoryService.ReadCategoryById(1);
            var createdAtActionResult = await Assert.IsType<Task<Category>>(result);
        }

        [Fact]
        public async Task CreateCategory_Success()
        {
            //Act - Check final result
            var result = categoryService.CreateCategory(new Category {CategoryName="Test demo 02", ParentId=0 });
            var createdAtActionResult = await Assert.IsType<Task<bool>>(result);
        }

        [Fact]
        public async Task UpdateCategory_Success()
        {
            //Act - Check final result
            var result = categoryService.UpdateCategory(1,new Category { CategoryName = "Test demo 02" });
            var createdAtActionResult = await Assert.IsType<Task<bool>>(result);
        }

        [Fact]
        public async Task DeleteCategory_Success()
        {
            //Act - Check final result
            var result = categoryService.DeleteCategory(1);
            var createdAtActionResult = await Assert.IsType<Task<bool>>(result);
        }
    }
}
