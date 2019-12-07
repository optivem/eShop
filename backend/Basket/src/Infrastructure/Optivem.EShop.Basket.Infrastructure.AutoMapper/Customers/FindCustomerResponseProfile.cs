using AutoMapper;
using Optivem.EShop.Basket.Core.Application.Customers.Responses;
using Optivem.EShop.Basket.Core.Domain.Customers;

namespace Optivem.EShop.Basket.Infrastructure.AutoMapper.Customers
{
    public class FindCustomerResponseProfile : Profile
    {
        public FindCustomerResponseProfile()
        {
            CreateMap<CustomerDetailReadModel, FindCustomerResponse>();
        }
    }
}