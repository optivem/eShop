﻿using System;

namespace Optivem.EShop.Basket.Core.Application.Products.Responses
{
    public class FindProductResponse
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }

        public bool IsListed { get; set; }
    }
}