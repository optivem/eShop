﻿using AutoMapper;
using Optivem.EShop.Basket.Core.Domain.Orders;
using System;

namespace Optivem.EShop.Basket.Infrastructure.AutoMapper.Orders
{
    public class OrderIdentityProfile : Profile
    {
        public OrderIdentityProfile()
        {
            CreateMap<OrderIdentity, Guid>()
                .ConvertUsing(src => src.Id);

            CreateMap<OrderItemIdentity, Guid>()
                .ConvertUsing(src => src.Id);
        }
    }
}