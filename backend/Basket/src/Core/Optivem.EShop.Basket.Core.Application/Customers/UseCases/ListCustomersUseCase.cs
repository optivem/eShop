using System.Threading.Tasks;
using Optivem.Framework.Core.Common;
using Optivem.Framework.Core.Common.Mapping;
using Optivem.Framework.Core.Domain;
using Optivem.EShop.Basket.Core.Application.Customers.Requests;
using Optivem.EShop.Basket.Core.Application.Customers.Responses;
using Optivem.EShop.Basket.Core.Domain.Customers;

namespace Optivem.EShop.Basket.Core.Application.Customers.UseCases
{
    public class ListCustomersUseCase : RequestHandler<ListCustomersRequest, ListCustomersResponse>
    {
        private readonly ICustomerReadRepository _customerReadRepository;

        public ListCustomersUseCase(IMapper mapper, ICustomerReadRepository customerReadRepository)
            : base(mapper)
        {
            _customerReadRepository = customerReadRepository;
        }

        public override async Task<ListCustomersResponse> HandleAsync(ListCustomersRequest request)
        {
            var listResult = await _customerReadRepository.ListAsync(request.NameSearch, request.Limit);

            return Mapper.Map<ListReadModel<CustomerIdNameReadModel>, ListCustomersResponse>(listResult);
        }
    }
}