using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;

namespace TheFakeShop.Backend.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderHeader>> ReadAllOrderCustomer(string customerEmail);

        Task<OrderHeader> ReadOrderById(int id);

        Task<bool> CreateOrder(OrderHeader order);

        Task<bool> UpdateOrderStatus(int id, string newStatus);
    }
}
