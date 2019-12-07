using Optivem.Framework.Core.Domain;

namespace Optivem.EShop.Basket.Core.Domain.Orders
{
    public class OrderIdNameReadModel : IdNameReadModel<OrderIdentity>
    {
        public OrderIdNameReadModel(OrderIdentity id, string name) : base(id, name)
        {
        }
    }
}
