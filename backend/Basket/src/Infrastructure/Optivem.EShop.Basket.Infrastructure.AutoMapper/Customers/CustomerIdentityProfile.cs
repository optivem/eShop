using AutoMapper;
using Optivem.EShop.Basket.Core.Domain.Customers;
using System;

namespace Optivem.EShop.Basket.Infrastructure.AutoMapper.Customers
{
    public class CustomerIdentityProfile : Profile
    {
        public CustomerIdentityProfile()
        {
            CreateMap<CustomerIdentity, Guid>()
                .ConvertUsing(src => src.Id);
        }
    }
}