using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TheFakeShop.ShareModels;

namespace TheFakeShop.Frontend.Services
{
    public class ProductApiClient : IProductApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ProductApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public async Task<IList<ProductViewModel>> GetProducts()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration.GetValue<string>("Backend")+"product");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IList<ProductViewModel>>();
        }
        public async Task<ProductViewModel> GetProductById(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration.GetValue<string>("Backend")+"product/" + id.ToString());
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<ProductViewModel>();
        }
        public async Task<IList<ProductViewModel>> GetProductsByCategoryId(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration.GetValue<string>("Backend") + "product/CategoryId="+ id.ToString());
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IList<ProductViewModel>>();
        }

        public async Task<bool> Rating(RatingCreateRequest rateRequest)
        {
            var client = _httpClientFactory.CreateClient();

            var json = JsonConvert.SerializeObject(rateRequest);
            
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await client.PostAsync(_configuration.GetValue<string>("Backend") +"Rating", data);

            res.EnsureSuccessStatusCode();

            if(res.ReasonPhrase.Equals("Created"))
            {
                return true;
            }
            else
            {
                return false;
            }
/*            var result = await res.Content.ReadAsAsync<bool>();

            return result;*/
        }
    }
}
