using Optivem.Framework.Core.Common;
using Optivem.EShop.Basket.Core.Application.Customers.Responses;

namespace Optivem.EShop.Basket.Core.Application.Customers.Requests
{
    public class BrowseCustomersRequest : IRequest<BrowseCustomersResponse>
    {
        public int Page { get; set; }

        public int Size { get; set; }
    }
}