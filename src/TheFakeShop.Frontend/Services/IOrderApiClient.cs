using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.ShareModels;

namespace TheFakeShop.Frontend.Services
{
    interface IOrderApiClient
    {
        Task<IList<OrderHeaderViewModel>> GetHistoryOrder(string customerEmail);

        Task<OrderHeaderViewModel> GetOrderById(int id);

        Task<bool> addOrder(OrderCreateRequest orderRequest);
    }
}
