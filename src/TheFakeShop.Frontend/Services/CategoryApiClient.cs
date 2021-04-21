using Microsoft.Extensions.Configuration;
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
        private readonly IConfiguration _configuration;

        public CategoryApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public async Task<IList<CategoryViewModel>> GetCategories()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration.GetValue<string>("Backend") +"categories");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IList<CategoryViewModel>>();
        }
    }
}