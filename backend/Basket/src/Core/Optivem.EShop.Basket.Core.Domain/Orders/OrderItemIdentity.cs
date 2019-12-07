using Optivem.Framework.Core.Domain;
using System;

namespace Optivem.EShop.Basket.Core.Domain.Orders
{
    public class OrderItemIdentity : Identity<Guid>
    {
        public static OrderItemIdentity New() => new OrderItemIdentity(Guid.NewGuid());

        public OrderItemIdentity(Guid id)
            : base(id)
        {
        }
    }
}