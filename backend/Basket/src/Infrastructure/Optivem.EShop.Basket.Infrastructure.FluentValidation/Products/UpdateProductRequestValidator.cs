using FluentValidation;
using Optivem.Framework.Infrastructure.FluentValidation;
using Optivem.EShop.Basket.Core.Application.Products.Requests;

namespace Optivem.EShop.Basket.Infrastructure.FluentValidation.Products
{
    public class UpdateProductRequestValidator : BaseValidator<UpdateProductRequest>
    {
        public UpdateProductRequestValidator()
        {
            RuleFor(e => e.Description).NotNull();
            RuleFor(e => e.UnitPrice).GreaterThan(0);
        }
    }
}