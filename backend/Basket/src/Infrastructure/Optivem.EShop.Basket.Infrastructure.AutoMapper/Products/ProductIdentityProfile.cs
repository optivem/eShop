using AutoMapper;
using Optivem.EShop.Basket.Core.Domain.Products;
using System;

namespace Optivem.EShop.Basket.Infrastructure.AutoMapper.Products
{
    public class ProductIdentityProfile : Profile
    {
        public ProductIdentityProfile()
        {
            CreateMap<ProductIdentity, Guid>()
                .ConvertUsing(src => src.Id);
        }
    }
}