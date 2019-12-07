﻿using Optivem.Framework.Core.Domain;
using System;

namespace Optivem.EShop.Basket.Core.Domain.Products
{
    public class ProductIdentity : Identity<Guid>
    {
        public static ProductIdentity New() => new ProductIdentity(Guid.NewGuid());

        public ProductIdentity(Guid id)
            : base(id)
        {
        }
    }
}