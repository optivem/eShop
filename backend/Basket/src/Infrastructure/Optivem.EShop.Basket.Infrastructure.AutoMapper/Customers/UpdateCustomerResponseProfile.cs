using AutoMapper;
using Optivem.EShop.Basket.Core.Application.Customers.Responses;
using Optivem.EShop.Basket.Core.Domain.Customers;

namespace Optivem.EShop.Basket.Infrastructure.AutoMapper.Customers
{
    public class UpdateCustomerResponseProfile : Profile
    {
        public UpdateCustomerResponseProfile()
        {
            CreateMap<Customer, UpdateCustomerResponse>();
        }
    }
}