using Optivem.Framework.Core.Common;
using Optivem.EShop.Basket.Core.Application.Customers.Responses;
using System;

namespace Optivem.EShop.Basket.Core.Application.Customers.Requests
{
    public class FindCustomerRequest : IRequest<FindCustomerResponse>
    {
        public Guid Id { get; set; }
    }
}