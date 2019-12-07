using Optivem.Framework.Core.Common;
using Optivem.EShop.Basket.Core.Application.Products.Responses;
using System;

namespace Optivem.EShop.Basket.Core.Application.Products.Requests
{
    public class FindProductRequest : IRequest<FindProductResponse>
    {
        public Guid Id { get; set; }
    }
}