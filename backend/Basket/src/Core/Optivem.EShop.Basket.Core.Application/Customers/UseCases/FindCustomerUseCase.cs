﻿using System.Threading.Tasks;
using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Common;
using Optivem.Framework.Core.Common.Mapping;
using Optivem.EShop.Basket.Core.Application.Customers.Requests;
using Optivem.EShop.Basket.Core.Application.Customers.Responses;
using Optivem.EShop.Basket.Core.Domain.Customers;

namespace Optivem.EShop.Basket.Core.Application.Customers.UseCases
{
    public class FindCustomerUseCase : RequestHandler<FindCustomerRequest, FindCustomerResponse>
    {
        private readonly ICustomerReadRepository _customerReadRepository;

        public FindCustomerUseCase(IMapper mapper, ICustomerReadRepository customerReadRepository)
            : base(mapper)
        {
            _customerReadRepository = customerReadRepository;
        }

        public override async Task<FindCustomerResponse> HandleAsync(FindCustomerRequest request)
        {
            var customerId = new CustomerIdentity(request.Id);

            var customerDetail = await _customerReadRepository.GetDetailAsync(customerId);

            if (customerDetail == null)
            {
                throw new NotFoundRequestException();
            }

            return Mapper.Map<CustomerDetailReadModel, FindCustomerResponse>(customerDetail);
        }
    }
}