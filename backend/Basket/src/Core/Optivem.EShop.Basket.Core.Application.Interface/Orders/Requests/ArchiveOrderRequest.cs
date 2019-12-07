using Optivem.Framework.Core.Common;
using Optivem.EShop.Basket.Core.Application.Orders.Responses;
using System;

namespace Optivem.EShop.Basket.Core.Application.Orders.Requests
{
    public class ArchiveOrderRequest : IRequest<ArchiveOrderResponse>
    {
        public Guid Id { get; set; }
    }
}