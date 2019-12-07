using System.Threading.Tasks;
using Optivem.Framework.Core.Common;
using Optivem.Framework.Core.Common.Mapping;
using Optivem.Framework.Core.Domain;
using Optivem.EShop.Basket.Core.Application.Products.Requests;
using Optivem.EShop.Basket.Core.Application.Products.Responses;
using Optivem.EShop.Basket.Core.Domain.Products;

namespace Optivem.EShop.Basket.Core.Application.Products.UseCases
{
    public class ListProductsUseCase : RequestHandler<ListProductRequest, ListProductsResponse>
    {
        private readonly IProductReadRepository _productReadRepository;

        public ListProductsUseCase(IMapper mapper, IProductReadRepository productReadRepository)
            : base(mapper)
        {
            _productReadRepository = productReadRepository;
        }

        public override async Task<ListProductsResponse> HandleAsync(ListProductRequest request)
        {
            var listResult = await _productReadRepository.ListAsync();

            return Mapper.Map<ListReadModel<ProductIdNameReadModel>, ListProductsResponse>(listResult);
        }
    }
}