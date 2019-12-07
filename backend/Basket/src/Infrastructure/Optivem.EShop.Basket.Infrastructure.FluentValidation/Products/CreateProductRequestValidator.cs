﻿using FluentValidation;
using Optivem.Framework.Infrastructure.FluentValidation;
using Optivem.EShop.Basket.Core.Application.Products.Requests;

namespace Optivem.EShop.Basket.Infrastructure.FluentValidation.Products
{
    public class CreateProductRequestValidator : BaseValidator<CreateProductRequest>
    {
        public CreateProductRequestValidator()
        {
            RuleFor(e => e.Code).NotNull();
            RuleFor(e => e.Description).NotNull();
            RuleFor(e => e.UnitPrice).GreaterThan(0);
        }
    }
}