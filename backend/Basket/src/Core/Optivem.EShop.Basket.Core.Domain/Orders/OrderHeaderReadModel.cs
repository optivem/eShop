using Optivem.EShop.Basket.Core.Common.Orders;
using Optivem.EShop.Basket.Core.Domain.Customers;
using System;

namespace Optivem.EShop.Basket.Core.Domain.Orders
{
    public class OrderHeaderReadModel
    {
        public OrderHeaderReadModel(OrderIdentity orderId, CustomerIdentity customerId, DateTime orderDate, OrderStatus status, decimal totalPrice)
        {
            OrderId = orderId;
            CustomerId = customerId;
            OrderDate = orderDate;
            Status = status;
            TotalPrice = totalPrice;
        }

        public OrderIdentity OrderId { get; }

        public CustomerIdentity CustomerId { get; }

        public DateTime OrderDate { get; }

        public OrderStatus Status { get; }

        public decimal TotalPrice { get; }
    }
}
