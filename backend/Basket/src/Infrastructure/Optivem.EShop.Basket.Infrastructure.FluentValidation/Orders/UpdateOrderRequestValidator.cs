using FluentValidation;
using Optivem.Framework.Infrastructure.FluentValidation;
using Optivem.EShop.Basket.Core.Application.Orders.Requests;

namespace Optivem.EShop.Basket.Infrastructure.FluentValidation.Orders
{
    public class UpdateOrderRequestValidator : BaseValidator<UpdateOrderRequest>
    {
        public UpdateOrderRequestValidator()
        {
            RuleFor(e => e.OrderItems).NotNull();
        }
    }
}