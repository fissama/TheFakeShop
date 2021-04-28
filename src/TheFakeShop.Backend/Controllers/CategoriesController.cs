using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;
using TheFakeShop.Backend.Services;
using TheFakeShop.ShareModels;

namespace TheFakeShop.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        /*private readonly TheFakeShopContext _context;

        public CategoriesController(TheFakeShopContext context)
        {
            _context = context;
        }
        
*/
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<CategoryViewModel>>> GetCategories()
        {
            /*return await _context.Categories
                .Select(x => new CategoryViewModel { Id = x.CategoryId, CategoryName = x.CategoryName, parentId = x.ParentId })
                .ToListAsync();*/
            var listCategory = await _categoryService.ReadAllCategory();
            var listCategoryVM = listCategory.Select(x => new CategoryViewModel { Id = x.CategoryId, CategoryName = x.CategoryName, parentId = x.ParentId });
            return listCategoryVM.ToList();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<CategoryViewModel>> GetCategory(int id)
        {
            /*var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            var cateVM = new CategoryViewModel
            {
                Id = category.CategoryId,
                CategoryName = category.CategoryName,
                parentId = category.ParentId
            };

            return cateVM;*/
            var getCategory = await _categoryService.ReadCategoryById(id);
            if (getCategory == null)
            {
                return NotFound();
            }
            var cateVM = new CategoryViewModel
            {
                Id = getCategory.CategoryId,
                CategoryName = getCategory.CategoryName,
                parentId = getCategory.ParentId
            };

            return cateVM;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, CategoryPostRequest cateRequest)
        {
            var putCategory = new Category
            {
                CategoryName = cateRequest.Name,
                ParentId = cateRequest.parentId
            };
            var isPutSuccessCategory = await _categoryService.UpdateCategory(id,putCategory);

            if (isPutSuccessCategory)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult<CategoryViewModel>> PostCategory(CategoryPostRequest cateRequest)
        {
            var postCategory = new Category
            {
                CategoryName = cateRequest.Name,
                ParentId = cateRequest.parentId
            };

            var isPostSuccessCategory = await _categoryService.CreateCategory(postCategory);

  
            if (isPostSuccessCategory)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var isDeleteSuccessCategory = await _categoryService.DeleteCategory(id);

            if (isDeleteSuccessCategory)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
