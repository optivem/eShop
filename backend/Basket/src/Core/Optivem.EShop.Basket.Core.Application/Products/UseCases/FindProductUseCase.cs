using System.Threading.Tasks;
using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Common;
using Optivem.Framework.Core.Common.Mapping;
using Optivem.EShop.Basket.Core.Application.Products.Requests;
using Optivem.EShop.Basket.Core.Application.Products.Responses;
using Optivem.EShop.Basket.Core.Domain.Products;

namespace Optivem.EShop.Basket.Core.Application.Products.UseCases
{
    public class FindProductUseCase : RequestHandler<FindProductRequest, FindProductResponse>
    {
        private readonly IProductReadRepository _productReadRepository;

        public FindProductUseCase(IMapper mapper, IProductReadRepository productReadRepository)
            : base(mapper)
        {
            _productReadRepository = productReadRepository;
        }

        public override async Task<FindProductResponse> HandleAsync(FindProductRequest request)
        {
            var productId = new ProductIdentity(request.Id);

            var product = await _productReadRepository.FindAsync(productId);

            if (product == null)
            {
                throw new NotFoundRequestException();
            }

            return Mapper.Map<Product, FindProductResponse>(product);
        }
    }
}