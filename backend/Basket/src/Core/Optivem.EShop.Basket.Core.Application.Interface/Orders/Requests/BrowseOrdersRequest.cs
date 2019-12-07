using Optivem.Framework.Core.Common;
using Optivem.EShop.Basket.Core.Application.Orders.Responses;

namespace Optivem.EShop.Basket.Core.Application.Orders.Requests
{
    public class BrowseOrdersRequest : IRequest<BrowseOrdersResponse>
    {
        public int Page { get; set; }

        public int Size { get; set; }
    }
}