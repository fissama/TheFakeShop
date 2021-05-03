using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;
using TheFakeShop.Backend.Repositories;

namespace TheFakeShop.Backend.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<OrderHeader>> ReadAllOrderCustomer(string customerEmail)
        {
            return await _orderRepository.ReadAllOrderCustomer(customerEmail);
        }

        public async Task<OrderHeader> ReadOrderById(int id)
        {
            if (await _orderRepository.FindById(id))
            {
                return await _orderRepository.ReadOrderById(id);
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> CreateOrder(OrderHeader order)
        {
            if (await _orderRepository.CreateOrder(order))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOrderStatus(int id, string newStatus)
        {
            if (await _orderRepository.UpdateOrderStatus(id,newStatus))
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
