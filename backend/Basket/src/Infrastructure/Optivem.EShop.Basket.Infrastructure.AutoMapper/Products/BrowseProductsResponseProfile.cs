﻿using AutoMapper;
using Optivem.Framework.Core.Domain;
using Optivem.EShop.Basket.Core.Application.Products.Responses;
using Optivem.EShop.Basket.Core.Domain.Products;

namespace Optivem.EShop.Basket.Infrastructure.AutoMapper.Products
{
    public class BrowseProductsResponseProfile : Profile
    {
        public BrowseProductsResponseProfile()
        {
            CreateMap<PageReadModel<ProductHeaderReadModel>, BrowseProductsResponse>()
                .ForMember(dest => dest.Records, opt => opt.MapFrom(e => e.Records))
                .ForMember(dest => dest.TotalRecords, opt => opt.MapFrom(e => e.TotalRecords));

            CreateMap<ProductHeaderReadModel, BrowseProductsRecordResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(e => e.ProductId))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(e => e.ProductCode))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(e => e.ProductName))
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(e => e.ListPrice));
        }
    }
}