using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;

namespace TheFakeShop.Backend.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TheFakeShopContext _context;

        public CategoryRepository(TheFakeShopContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> ReadAllCategory()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> ReadCategoryById(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<bool> CreateCategory(Category category)
        {
            category.ParentId = category.ParentId == 0 ? null : category.ParentId;
            _context.Add(category);
            if (await _context.SaveChangesAsync() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateCategory(int id,Category category)
        {
            var categoryOld = await _context.Categories.FindAsync(id);
            categoryOld.CategoryName = category.CategoryName;
            categoryOld.ParentId = category.ParentId==0?null:category.ParentId;
            if (await _context.SaveChangesAsync() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteCategory(int id)
        {
            var categoryOld = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(categoryOld);
            if (await _context.SaveChangesAsync() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> FindById(int id)
        {
            var findCategory = await _context.Categories.FindAsync(id);
            var isCategoryFound = (findCategory.CategoryId == id);
            return isCategoryFound;
        }
    }
}
