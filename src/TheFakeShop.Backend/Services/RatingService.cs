using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;
using TheFakeShop.Backend.Repositories;

namespace TheFakeShop.Backend.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;

        public RatingService(IRatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        public async Task<bool> CreateRating(ProductRating rating)
        {
            if (await _ratingRepository.CreateRating(rating))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
