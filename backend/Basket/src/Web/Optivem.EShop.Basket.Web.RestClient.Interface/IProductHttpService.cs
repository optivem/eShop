using Optivem.Framework.Core.Common.Http;
using Optivem.EShop.Basket.Core.Application.Products.Requests;
using Optivem.EShop.Basket.Core.Application.Products.Responses;
using System.Threading.Tasks;

namespace Optivem.EShop.Basket.Web.RestClient.Interface
{
    public interface IProductHttpService : IHttpService
    {
        Task<IObjectClientResponse<BrowseProductsResponse>> BrowseProductsAsync(BrowseProductsRequest request);

        Task<IObjectClientResponse<CreateProductResponse>> CreateProductAsync(CreateProductRequest request);

        Task<IObjectClientResponse<FindProductResponse>> FindProductAsync(FindProductRequest request);

        Task<IObjectClientResponse<ListProductsResponse>> ListProductsAsync(ListProductRequest request);

        Task<IObjectClientResponse<RelistProductResponse>> RelistProductAsync(RelistProductRequest request);

        Task<IObjectClientResponse<UnlistProductResponse>> UnlistProductAsync(UnlistProductRequest request);

        Task<IObjectClientResponse<UpdateProductResponse>> UpdateProductAsync(UpdateProductRequest request);
    }
}