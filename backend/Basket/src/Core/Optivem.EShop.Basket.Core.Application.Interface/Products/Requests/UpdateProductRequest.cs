using Optivem.Framework.Core.Common;
using Optivem.EShop.Basket.Core.Application.Products.Responses;
using System;

namespace Optivem.EShop.Basket.Core.Application.Products.Requests
{
    public class UpdateProductRequest : IRequest<UpdateProductResponse>
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }
    }
}