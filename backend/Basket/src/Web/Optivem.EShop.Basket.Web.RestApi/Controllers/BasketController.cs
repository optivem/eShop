using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Optivem.EShop.Basket.Web.RestApi.Controllers
{
    [Route("api/v1/baskets")]
    [Authorize] // TODO: Implement authorization
    [ApiController]
    public class BasketController
    {

    }
}
