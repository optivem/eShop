using Optivem.Framework.Core.Common;
using Optivem.EShop.Basket.Core.Application.Customers.Responses;
using System;

namespace Optivem.EShop.Basket.Core.Application.Customers.Requests
{
    public class DeleteCustomerRequest : IRequest<DeleteCustomerResponse>
    {
        public Guid Id { get; set; }
    }
}