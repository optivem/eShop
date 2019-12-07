﻿using Optivem.Framework.Infrastructure.AspNetCore;
using Optivem.EShop.Basket.Core.Application.Products;
using Optivem.EShop.Basket.Core.Application.Products.Requests;
using Optivem.EShop.Basket.Core.Application.Products.Responses;
using Optivem.EShop.Basket.Web.RestClient.Interface;
using System.Threading.Tasks;

namespace Optivem.EShop.Basket.Web.RestClient
{
    public class ProductService : BaseHttpService<IProductHttpService>, IProductService
    {
        public ProductService(IProductHttpService service) : base(service)
        {
        }

        public Task<RelistProductResponse> RelistProductAsync(RelistProductRequest request)
        {
            return ExecuteAsync(e => e.RelistProductAsync(request));
        }

        public Task<BrowseProductsResponse> BrowseProductsAsync(BrowseProductsRequest request)
        {
            return ExecuteAsync(e => e.BrowseProductsAsync(request));
        }

        public Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request)
        {
            return ExecuteAsync(e => e.CreateProductAsync(request));
        }

        public Task<UnlistProductResponse> UnlistProductAsync(UnlistProductRequest request)
        {
            return ExecuteAsync(e => e.UnlistProductAsync(request));
        }

        public Task<FindProductResponse> FindProductAsync(FindProductRequest request)
        {
            return ExecuteAsync(e => e.FindProductAsync(request));
        }

        public Task<ListProductsResponse> ListProductsAsync(ListProductRequest request)
        {
            return ExecuteAsync(e => e.ListProductsAsync(request));
        }

        public Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest request)
        {
            return ExecuteAsync(e => e.UpdateProductAsync(request));
        }
    }
}