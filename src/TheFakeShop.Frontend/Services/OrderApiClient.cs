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
    public class OrderApiClient : IOrderApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public OrderApiClient(IHttpClientFactory httpClientFactory,IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<bool> addOrder(OrderCreateRequest orderRequest)
        {
            var client = _httpClientFactory.CreateClient();

            var json = JsonConvert.SerializeObject(orderRequest);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await client.PostAsync(_configuration.GetValue<string>("Backend") + "Order", data);

            res.EnsureSuccessStatusCode();

            if (res.ReasonPhrase.Equals("Created"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<IList<OrderHeaderViewModel>> GetHistoryOrder(string customerEmail)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration.GetValue<string>("Backend")+"order?customerEmail="+customerEmail);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IList<OrderHeaderViewModel>>();
        }

        public async Task<OrderHeaderViewModel> GetOrderById(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration.GetValue<string>("Backend") + "order/" + id.ToString());
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<OrderHeaderViewModel>();
        }
    }
}
