using Optivem.Framework.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.EShop.Basket.Core.Domain.Baskets
{
    public class Basket : Entity<BasketIdentity>
    {
        public Basket(BasketIdentity id) : base(id)
        {
        }
    }
}
