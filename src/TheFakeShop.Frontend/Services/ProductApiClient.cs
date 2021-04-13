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

        public ProductApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IList<ProductViewModel>> GetProducts()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:44358/product");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IList<ProductViewModel>>();
        }
        public async Task<ProductViewModel> GetProductById(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:44358/product/"+id.ToString());
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<ProductViewModel>();
        }
        public async Task<IList<ProductViewModel>> GetProductsByCategoryId(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:44358/product/CategoryId="+ id.ToString());
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IList<ProductViewModel>>();
        }

        public async Task<bool> Rating(RatingCreateRequest rateRequest)
        {
            var client = _httpClientFactory.CreateClient();

            var json = JsonConvert.SerializeObject(rateRequest);
            
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await client.PostAsync("https://localhost:44358/Rating", data);

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
