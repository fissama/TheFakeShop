using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TheFakeShop.ShareModels;

namespace TheFakeShop.Frontend.Services
{
    public class CategoryApiClient : ICategoryApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IList<CategoryViewModel>> GetCategories()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:44358/categories");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IList<CategoryViewModel>>();
        }
    }
}