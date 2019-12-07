using Optivem.Framework.Core.Common;
using Optivem.EShop.Basket.Core.Application.Customers.Responses;

namespace Optivem.EShop.Basket.Core.Application.Customers.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}