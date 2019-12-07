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
    public class UpdateBasketUseCase : RequestHandler<UpdateBasketRequest, UpdateBasketResponse>
    {
        public UpdateBasketUseCase(IMapper mapper) : base(mapper)
        {
        }

        public override Task<UpdateBasketResponse> HandleAsync(UpdateBasketRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
