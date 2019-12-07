﻿using System.Threading.Tasks;
using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Common;
using Optivem.Framework.Core.Common.Mapping;
using Optivem.EShop.Basket.Core.Application.Orders.Requests;
using Optivem.EShop.Basket.Core.Application.Orders.Responses;
using Optivem.EShop.Basket.Core.Domain.Orders;

namespace Optivem.EShop.Basket.Core.Application.Orders.UseCases
{
    public class FindOrderUseCase : RequestHandler<FindOrderRequest, FindOrderResponse>
    {
        private readonly IOrderReadRepository _orderReadRepository;

        public FindOrderUseCase(IMapper mapper, IOrderReadRepository orderReadRepository)
            : base(mapper)
        {
            _orderReadRepository = orderReadRepository;
        }

        public override async Task<FindOrderResponse> HandleAsync(FindOrderRequest request)
        {
            var orderId = new OrderIdentity(request.Id);

            var order = await _orderReadRepository.FindAsync(orderId);

            if (order == null)
            {
                throw new NotFoundRequestException();
            }

            var response = Mapper.Map<Order, FindOrderResponse>(order);
            return response;
        }
    }
}