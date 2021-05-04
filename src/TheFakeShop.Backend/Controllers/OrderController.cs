using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheFakeShop.Backend.Models;
using TheFakeShop.Backend.Services;
using TheFakeShop.ShareModels;

namespace TheFakeShop.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<OrderHeaderViewModel>>> GetOrdersByCustomerEmail(string customerEmail)
        {
            var listOrderHeader = await _orderService.ReadAllOrderCustomer(customerEmail);
            var listOrderVM = listOrderHeader.Select(x => new OrderHeaderViewModel { OrderId = x.OrderId, Cost = x.Cost, CreatedAt = x.CreatedAt, OrderStatus = x.OrderStatus });
            return listOrderVM.ToList();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<OrderHeaderViewModel>> GetOrder(int id)
        {
            var getOrder = await _orderService.ReadOrderById(id);
            if (getOrder == null)
            {
                return NotFound();
            }
            IList<OrderDetailViewModel> getDetails = new List<OrderDetailViewModel>();
            foreach(var el in getOrder.OrderDetails)
            {
                getDetails.Add(new OrderDetailViewModel
                {
                    Qty = el.Qty,
                    ProductId = el.ProductId,
                    OrderId = el.OrderId
                });
            }
            var orderVM = new OrderHeaderViewModel
            {
                OrderId = getOrder.OrderId,
                Phone = getOrder.Phone,
                Cost = getOrder.Cost,
                CustomerEmail = getOrder.CustomerEmail,
                CreatedAt = getOrder.CreatedAt,
                FullAddress = getOrder.FullAddress,
                OrderStatus = getOrder.OrderStatus,
                orderDetail = getDetails
            };

            return orderVM;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderStatus(int id, string newStatus)
        {
            var isPutSuccessCategory = await _orderService.UpdateOrderStatus(id, newStatus);

            if (isPutSuccessCategory)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostOrder(OrderCreateRequest orderRequest)
        {
            var postOrder = new OrderHeader
            {
                Phone = orderRequest.Phone,
                CustomerEmail = orderRequest.CustomerEmail,
                Cost = orderRequest.Cost,
                FullAddress = orderRequest.FullAddress,
                OrderStatus = orderRequest.OrderStatus
            };
            foreach(var el in orderRequest.orderDetail)
            {
                postOrder.OrderDetails.Add(new OrderDetail
                {
                    Qty = el.Qty,
                    ProductId = el.ProductId,
                    Order = postOrder
                });
            }

            var isPostSuccessOrder = await _orderService.CreateOrder(postOrder);


            if (isPostSuccessOrder)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
