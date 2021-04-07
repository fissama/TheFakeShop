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
    public class RatingController : ControllerBase
    {
        private readonly TheFakeShopContext _context;

        public RatingController(TheFakeShopContext context)
        {
            _context = context;
        }


        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<RatingViewModel>>> GetRatingByProductID(int id)
        {
            return await _context.ProductRatings
                .Where(x => x.ProductId == id)
                .Select(x => new RatingViewModel { PratingId = x.PratingId, CustomerName = x.CustomerName, CustomerEmail = x.CustomerEmail, Content = x.Content, Rating = x.Rating, Title = x.Title, ProductID = x.ProductId })
                .ToListAsync();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, RatingCreateRequest rateRequest)
        {
            var rating = await _context.ProductRatings.FindAsync(id);

            if (rating == null)
            {
                return NotFound();
            }

            rating.Rating = rateRequest.Rating;
            rating.Title = rateRequest.Title;
            rating.CustomerEmail = rateRequest.CustomerEmail;
            rating.CustomerName = rateRequest.CustomerName;
            rating.Content = rateRequest.Content;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<RatingViewModel>> PostRating(RatingCreateRequest rateRequest)
        {
            var rating = new ProductRating
            {
                ProductId = rateRequest.ProductID,
                CustomerName = rateRequest.CustomerName,
                CustomerEmail = rateRequest.CustomerEmail,
                Title = rateRequest.Title,
                Content = rateRequest.Content,
                Rating = rateRequest.Rating
            };

            _context.ProductRatings.Add(rating);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRating", new { id = rating.PratingId }, new RatingViewModel { PratingId = rating.PratingId, CustomerName = rating.CustomerName, 
                CustomerEmail = rating.CustomerEmail, Rating = rating.Rating, Title = rating.Title, Content = rating.Content, ProductID = rating.ProductId});
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var rating = await _context.ProductRatings.FindAsync(id);
            if (rating == null)
            {
                return NotFound();
            }

            _context.ProductRatings.Remove(rating);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}