using FluentValidation;
using Optivem.Framework.Infrastructure.FluentValidation;
using Optivem.EShop.Basket.Core.Application.Customers.Requests;

namespace Optivem.EShop.Basket.Infrastructure.FluentValidation.Customers
{
    public class UpdateCustomerRequestValidator : BaseValidator<UpdateCustomerRequest>
    {
        public UpdateCustomerRequestValidator()
        {
            RuleFor(e => e.FirstName).NotNull();
            RuleFor(e => e.LastName).NotNull();
        }
    }
}