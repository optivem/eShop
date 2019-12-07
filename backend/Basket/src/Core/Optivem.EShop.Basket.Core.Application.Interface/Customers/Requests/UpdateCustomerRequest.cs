using Optivem.Framework.Core.Common;
using Optivem.EShop.Basket.Core.Application.Customers.Responses;
using System;

namespace Optivem.EShop.Basket.Core.Application.Customers.Requests
{
    public class UpdateCustomerRequest : IRequest<UpdateCustomerResponse>
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}