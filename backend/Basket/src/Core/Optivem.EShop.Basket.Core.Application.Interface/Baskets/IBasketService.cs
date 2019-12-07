using Optivem.EShop.Basket.Core.Application.Baskets.Requests;
using Optivem.EShop.Basket.Core.Application.Baskets.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.EShop.Basket.Core.Application.Baskets
{
    public interface IBasketService
    {
        Task<CheckoutBasketResponse> CheckoutBasketAsync(CheckoutBasketRequest request);

        Task<DeleteBasketResponse> DeleteBasketAsync(DeleteBasketRequest request);

        Task<FindBasketResponse> FindBasketAsync(FindBasketRequest request);

        Task<UpdateBasketResponse> UpdateBasketAsync(UpdateBasketRequest request);
    }
}
