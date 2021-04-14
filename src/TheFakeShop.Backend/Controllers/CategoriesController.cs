using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;
using TheFakeShop.ShareModels;

namespace TheFakeShop.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly TheFakeShopContext _context;

        public CategoriesController(TheFakeShopContext context)
        {
            _context = context;
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<CategoryViewModel>>> GetCategories()
        {
            return await _context.Categories
                .Select(x => new CategoryViewModel { Id = x.CategoryId, CategoryName = x.CategoryName, parentId = x.ParentId })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<CategoryViewModel>> GetCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);

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

            return cateVM;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, CategoryPostRequest cateRequest)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            category.CategoryName = cateRequest.Name;
            category.ParentId = cateRequest.parentId == 0 ? null : cateRequest.parentId;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<CategoryViewModel>> PostCategory(CategoryPostRequest cateRequest)
        {
            var category = new Category
            {
                CategoryName = cateRequest.Name,
                ParentId = cateRequest.parentId==0?null:cateRequest.parentId
            };

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategory", new { id = category.CategoryId }, new CategoryViewModel { Id = category.CategoryId, CategoryName = category.CategoryName, parentId = category.ParentId });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
