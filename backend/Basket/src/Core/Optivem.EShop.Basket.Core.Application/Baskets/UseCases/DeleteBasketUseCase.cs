using Optivem.EShop.Basket.Core.Application.Baskets.Requests;
using Optivem.EShop.Basket.Core.Application.Baskets.Responses;
using Optivem.Framework.Core.Common;
using Optivem.Framework.Core.Common.Mapping;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Optivem.EShop.Basket.Core.Application.Baskets.UseCases
{
    public class DeleteBasketUseCase : RequestHandler<DeleteBasketRequest, DeleteBasketResponse>
    {
        public DeleteBasketUseCase(IMapper mapper) : base(mapper)
        {
        }

        public override Task<DeleteBasketResponse> HandleAsync(DeleteBasketRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
