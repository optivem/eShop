using Optivem.Framework.Core.Common;
using Optivem.EShop.Basket.Core.Application.Orders.Responses;
using System;

namespace Optivem.EShop.Basket.Core.Application.Orders.Requests
{
    public class CancelOrderRequest : IRequest<CancelOrderResponse>
    {
        public Guid Id { get; set; }
    }
}