﻿using Optivem.EShop.Basket.Core.Common.Orders;
using System;
using System.Collections.Generic;

namespace Optivem.EShop.Basket.Core.Application.Orders.Responses
{
    public class FindOrderResponse
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public OrderStatus Status { get; set; }

        public List<FindOrderItemResponse> OrderItems { get; set; }
    }

    public class FindOrderItemResponse
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public decimal Quantity { get; set; }

        public OrderItemStatus Status { get; set; }
    }
}