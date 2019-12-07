﻿using Optivem.Framework.Core.Common;
using Optivem.Framework.Core.Common.Mapping;
using Optivem.Framework.Core.Domain;
using Optivem.EShop.Basket.Core.Application.Products.Requests;
using Optivem.EShop.Basket.Core.Application.Products.Responses;
using Optivem.EShop.Basket.Core.Domain.Products;
using System.Threading.Tasks;

namespace Optivem.EShop.Basket.Core.Application.Products.UseCases
{
    public class BrowseProductsUseCase : RequestHandler<BrowseProductsRequest, BrowseProductsResponse>
    {
        private readonly IProductReadRepository _productReadRepository;

        public BrowseProductsUseCase(IMapper mapper, IProductReadRepository productReadRepository)
            : base(mapper)
        {
            _productReadRepository = productReadRepository;
        }

        public override async Task<BrowseProductsResponse> HandleAsync(BrowseProductsRequest request)
        {
            var pageQuery = new PageQuery(request.Page, request.Size);
            var pageResult = await _productReadRepository.GetPageAsync(pageQuery);

            return Mapper.Map<PageReadModel<ProductHeaderReadModel>, BrowseProductsResponse>(pageResult);
        }
    }
}