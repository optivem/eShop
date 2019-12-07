using Optivem.Framework.Core.Common.Http;
using Optivem.Framework.Infrastructure.AspNetCore;
using Optivem.EShop.Basket.Web.RestClient.Interface;

namespace Optivem.EShop.Basket.Web.RestClient.Http
{
    public class ApiHttpService : BaseApiClient, IApiHttpService
    {
        public ApiHttpService(IControllerClientFactory clientFactory)
            : base(clientFactory)
        {
            Customers = new CustomerHttpService(clientFactory);
            Orders = new OrderHttpService(clientFactory);
            Products = new ProductHttpService(clientFactory);
        }

        public ICustomerHttpService Customers { get; }

        public IOrderHttpService Orders { get; }

        public IProductHttpService Products { get; }
    }
}