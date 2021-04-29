using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;

namespace TheFakeShop.Backend.Repositories
{
    public interface IRatingRepository
    {
        Task<bool> CreateRating(ProductRating rating);
    }
}
