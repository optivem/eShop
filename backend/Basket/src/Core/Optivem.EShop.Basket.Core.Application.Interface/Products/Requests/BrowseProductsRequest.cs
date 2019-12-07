using Optivem.Framework.Core.Common;
using Optivem.EShop.Basket.Core.Application.Products.Responses;

namespace Optivem.EShop.Basket.Core.Application.Products.Requests
{
    public class BrowseProductsRequest : IRequest<BrowseProductsResponse>
    {
        public int Page { get; set; }

        public int Size { get; set; }
    }
}