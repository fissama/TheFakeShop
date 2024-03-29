﻿using TheFakeShop.ShareModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TheFakeShop.Frontend.Services
{
    public interface ICategoryApiClient
    {
        Task<IList<CategoryViewModel>> GetCategories();
    }
}