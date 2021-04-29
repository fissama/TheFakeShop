using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;
using TheFakeShop.Backend.Repositories;
using Xunit;

namespace TheFakeShop.Test.BackendTest.TestRepositories
{
    public class CategoriesRepositoryTest : IClassFixture<SqliteInMemoryFixture>
    {
        private readonly SqliteInMemoryFixture _fixture;

        public CategoriesRepositoryTest(SqliteInMemoryFixture fixture)
        {
            _fixture = fixture;
            _fixture.CreateDatabase();
        }

        [Fact]
        public async Task PostCategory_Success()
        {
            var dbContext = _fixture.Context;
            var category = new Category { CategoryName = "Test category" };

            var repository = new CategoryRepository(dbContext);
            var result = await repository.CreateCategory(category);

            Assert.True(result);
            Assert.NotEmpty(await repository.ReadAllCategory());
        }

        [Fact]
        public async Task PutCategory_Success()
        {
            var dbContext = _fixture.Context;
            dbContext.Categories.Add(new Category { CategoryName = "Test category" });
            await dbContext.SaveChangesAsync();

            var oldCategory = await dbContext.Categories.OrderByDescending(x => x.CategoryId).FirstAsync();
            var category = new Category{ CategoryName = "Test put category" };

            var repository = new CategoryRepository(dbContext);
            var result = await repository.UpdateCategory(oldCategory.CategoryId,category);

            var returnValue = await dbContext.Categories.OrderByDescending(x => x.CategoryId).FirstAsync();
            Assert.True(result);
            Assert.Equal("Test put category", returnValue.CategoryName);
        }

        [Fact]
        public async Task DeleteCategory_Success()
        {
            var dbContext = _fixture.Context;
            dbContext.Categories.Add(new Category { CategoryName = "Test category" });
            await dbContext.SaveChangesAsync();

            var oldCategory = await dbContext.Categories.OrderByDescending(x => x.CategoryId).FirstAsync();

            var repository = new CategoryRepository(dbContext);
            var result = await repository.DeleteCategory(oldCategory.CategoryId);

            var returnValue = await dbContext.Categories.ToListAsync();
            Assert.True(result);
            Assert.Empty(returnValue);
        }

        [Fact]
        public async Task GetCategory_Success()
        {
            var dbContext = _fixture.Context;
            dbContext.Categories.Add(new Category { CategoryName = "Test category" });
            await dbContext.SaveChangesAsync();

            var repository = new CategoryRepository(dbContext);
            var result = await repository.ReadAllCategory();

            Assert.NotEmpty(result);
        }
    }
}
