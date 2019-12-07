using AutoMapper;
using Optivem.EShop.Basket.Core.Application.Products.Responses;
using Optivem.EShop.Basket.Core.Domain.Products;

namespace Optivem.EShop.Basket.Infrastructure.AutoMapper.Products
{
    public class UpdateProductResponseProfile : Profile
    {
        public UpdateProductResponseProfile()
        {
            CreateMap<Product, UpdateProductResponse>()
                .ForMember(dest => dest.Code, opt => opt.MapFrom(e => e.ProductCode))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(e => e.ProductName))
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(e => e.ListPrice));
        }
    }
}