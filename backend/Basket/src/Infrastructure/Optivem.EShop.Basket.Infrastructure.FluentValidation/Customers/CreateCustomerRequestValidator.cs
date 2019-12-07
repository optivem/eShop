using FluentValidation;
using Optivem.Framework.Infrastructure.FluentValidation;
using Optivem.EShop.Basket.Core.Application.Customers.Requests;

namespace Optivem.EShop.Basket.Infrastructure.FluentValidation.Customers
{
    public class CreateCustomerRequestValidator : BaseValidator<CreateCustomerRequest>
    {
        public CreateCustomerRequestValidator()
        {
            RuleFor(e => e.FirstName).NotNull();
            RuleFor(e => e.LastName).NotNull();
        }
    }
}