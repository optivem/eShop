﻿using Optivem.Framework.Core.Application;
using Optivem.EShop.Basket.Core.Application.Orders.Requests;
using Optivem.EShop.Basket.Core.Application.Orders.Responses;
using System.Threading.Tasks;

namespace Optivem.EShop.Basket.Core.Application.Orders
{
    public interface IOrderService : IApplicationService
    {
        Task<ArchiveOrderResponse> ArchiveOrderAsync(ArchiveOrderRequest request);

        Task<BrowseOrdersResponse> BrowseOrdersAsync(BrowseOrdersRequest request);

        Task<CancelOrderResponse> CancelOrderAsync(CancelOrderRequest request);

        Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request);

        Task<FindOrderResponse> FindOrderAsync(FindOrderRequest request);

        Task<ListOrdersResponse> ListOrdersAsync(ListOrdersRequest request);

        Task<SubmitOrderResponse> SubmitOrderAsync(SubmitOrderRequest request);

        Task<UpdateOrderResponse> UpdateOrderAsync(UpdateOrderRequest request);
    }
}