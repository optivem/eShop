using AutoMapper;
using Optivem.EShop.Basket.Core.Application.Orders.Responses;
using Optivem.EShop.Basket.Core.Domain.Orders;

namespace Optivem.EShop.Basket.Infrastructure.AutoMapper.Orders
{
    public class FindOrderResponseProfile : Profile
    {
        public FindOrderResponseProfile()
        {
            CreateMap<Order, FindOrderResponse>()
                .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(e => e.OrderItems));

            CreateMap<OrderItem, FindOrderItemResponse>();
        }
    }
}