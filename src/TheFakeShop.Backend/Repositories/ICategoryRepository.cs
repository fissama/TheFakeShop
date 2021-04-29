using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;

namespace TheFakeShop.Backend.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ReadAllCategory();

        Task<Category> ReadCategoryById(int id);

        Task<bool> CreateCategory(Category category);

        Task<bool> UpdateCategory(int id, Category category);

        Task<bool> DeleteCategory(int id);

        Task<bool> FindById(int id);
    }
}
