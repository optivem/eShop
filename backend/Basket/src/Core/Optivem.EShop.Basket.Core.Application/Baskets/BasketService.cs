using Optivem.EShop.Basket.Core.Application.Baskets.Requests;
using Optivem.EShop.Basket.Core.Application.Baskets.Responses;
using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.EShop.Basket.Core.Application.Baskets
{
    public class BasketService : ApplicationService, IBasketService
    {
        public BasketService(IRequestHandler requestHandler) : base(requestHandler)
        {
        }

        public Task<CheckoutBasketResponse> CheckoutBasketAsync(CheckoutBasketRequest request)
        {
            return HandleAsync<CheckoutBasketRequest, CheckoutBasketResponse>(request);
        }

        public Task<DeleteBasketResponse> DeleteBasketAsync(DeleteBasketRequest request)
        {
            return HandleAsync<DeleteBasketRequest, DeleteBasketResponse>(request);
        }

        public Task<FindBasketResponse> FindBasketAsync(FindBasketRequest request)
        {
            return HandleAsync<FindBasketRequest, FindBasketResponse>(request);
        }

        public Task<UpdateBasketResponse> UpdateBasketAsync(UpdateBasketRequest request)
        {
            return HandleAsync<UpdateBasketRequest, UpdateBasketResponse>(request);
        }
    }
}
