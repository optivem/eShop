using Optivem.Framework.Core.Common;
using Optivem.EShop.Basket.Core.Application.Products.Responses;
using System;

namespace Optivem.EShop.Basket.Core.Application.Products.Requests
{
    public class RelistProductRequest : IRequest<RelistProductResponse>
    {
        public Guid Id { get; set; }
    }
}