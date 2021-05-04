using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;

namespace TheFakeShop.Backend.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        private readonly TheFakeShopContext _context;

        public RatingRepository(TheFakeShopContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateRating(ProductRating rating)
        {
            _context.Add(rating);
            if (await _context.SaveChangesAsync() > 0)
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
