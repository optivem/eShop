using Optivem.Framework.Core.Common;
using Optivem.EShop.Basket.Core.Application.Customers.Responses;

namespace Optivem.EShop.Basket.Core.Application.Customers.Requests
{
    public class ListCustomersRequest : IRequest<ListCustomersResponse>
    {
        public string NameSearch { get; set; }

        public int Limit { get; set; }
    }
}