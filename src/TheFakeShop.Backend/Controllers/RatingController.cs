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
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpPost]
        public async Task<IActionResult> PostRating(RatingCreateRequest rateRequest)
        {
            var postRating = new ProductRating
            {
                ProductId = rateRequest.ProductID,
                CustomerName = rateRequest.CustomerName,
                CustomerEmail = rateRequest.CustomerEmail,
                Title = rateRequest.Title,
                Content = rateRequest.Content,
                Rating = rateRequest.Rating
            };

            var isPostSuccessRating = await _ratingService.CreateRating(postRating);


            if (isPostSuccessRating)
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