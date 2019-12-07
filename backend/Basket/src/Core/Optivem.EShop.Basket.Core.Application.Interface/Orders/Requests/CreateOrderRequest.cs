﻿using Optivem.Framework.Core.Common;
using Optivem.EShop.Basket.Core.Application.Orders.Responses;
using System;
using System.Collections.Generic;

namespace Optivem.EShop.Basket.Core.Application.Orders.Requests
{
    public class CreateOrderRequest : IRequest<CreateOrderResponse>
    {
        public Guid CustomerId { get; set; }

        public List<CreateOrderItemRequest> OrderItems { get; set; }
    }

    public class CreateOrderItemRequest
    {
        public Guid ProductId { get; set; }

        public decimal Quantity { get; set; }
    }
}