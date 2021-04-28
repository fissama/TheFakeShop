using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;
using TheFakeShop.Backend.Repositories;

namespace TheFakeShop.Backend.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ReadAllCategory()
        {
            return await _categoryRepository.ReadAllCategory();
        }

        public async Task<Category> ReadCategoryById(int id)
        {
            if (await _categoryRepository.FindById(id))
            {
                return await _categoryRepository.ReadCategoryById(id);
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> CreateCategory(Category category)
        {
            if(await _categoryRepository.CreateCategory(category))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateCategory(int id, Category category)
        {
            if (await _categoryRepository.FindById(id))
            {
                return await _categoryRepository.UpdateCategory(id, category);
            }
            else 
            { 
                return false;
            }
        }

        public async Task<bool> DeleteCategory(int id)
        {
            if (await _categoryRepository.FindById(id))
            {
                return await _categoryRepository.DeleteCategory(id);
            }
            else
            {
                return false;
            }
        }
    }
}
