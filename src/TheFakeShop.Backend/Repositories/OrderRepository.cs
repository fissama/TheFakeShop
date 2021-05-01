using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;

namespace TheFakeShop.Backend.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly TheFakeShopContext _context;

        public OrderRepository(TheFakeShopContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateOrder(OrderHeader order)
        {
            _context.OrderHeaders.Add(order);
            if (await _context.SaveChangesAsync() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> FindById(int id)
        {
            var findOrder = await _context.OrderHeaders.FindAsync(id);
            if (findOrder == null)
            {
                return false;
            }
            var isOrderFound = (findOrder.OrderId == id);
            return isOrderFound;
        }

        public async Task<IEnumerable<OrderHeader>> ReadAllOrderCustomer(string customerEmail)
        {
            return await _context.OrderHeaders.Where(x=>x.CustomerEmail==customerEmail).ToListAsync();
        }

        public async Task<OrderHeader> ReadOrderById(int id)
        {
            return await _context.OrderHeaders.Include(x => x.OrderDetails).Where(x => x.OrderId == id).FirstAsync();
        }

        public async Task<bool> UpdateOrderStatus(int id, string newStatus)
        {
            var oldOrder = await _context.OrderHeaders.FindAsync(id);
            oldOrder.OrderStatus = newStatus;
            if (await _context.SaveChangesAsync() > 0)
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
