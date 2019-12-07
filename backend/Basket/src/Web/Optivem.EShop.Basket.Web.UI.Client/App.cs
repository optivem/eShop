using Optivem.Framework.Infrastructure.Selenium;
using Optivem.EShop.Basket.Web.UI.Client.Interface;
using Optivem.EShop.Basket.Web.UI.Client.Interface.Pages;
using Optivem.EShop.Basket.Web.UI.Client.Pages;

namespace Optivem.EShop.Basket.Web.UI.Client
{
    public class App : App<CreateCustomerPage>, IApp
    {
        public App(Driver finder, string url) : base(finder)
        {
            Url = url;
        }

        public string Url { get; }

        public ICreateCustomerPage NavigateToCreateCustomerPage()
        {
            return new CreateCustomerPage(Url, Finder, true);
        }
    }
}