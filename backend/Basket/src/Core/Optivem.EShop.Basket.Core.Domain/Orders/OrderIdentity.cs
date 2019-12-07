using Optivem.Framework.Core.Domain;
using System;

namespace Optivem.EShop.Basket.Core.Domain.Orders
{
    public class OrderIdentity : Identity<Guid>
    {
        public static OrderIdentity New() => new OrderIdentity(Guid.NewGuid());

        public OrderIdentity(Guid id) : base(id)
        {
        }
    }
}