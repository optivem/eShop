using Optivem.Framework.Core.Common;
using Optivem.EShop.Basket.Core.Application.Products.Responses;

namespace Optivem.EShop.Basket.Core.Application.Products.Requests
{
    public class CreateProductRequest : IRequest<CreateProductResponse>
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }
    }
}