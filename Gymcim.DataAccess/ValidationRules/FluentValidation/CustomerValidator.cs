using FluentValidation;
using Gymcim.Entities.Concrete;

namespace Gymcim.DataAccess.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(e => e.CustomerName).NotEmpty();
            RuleFor(e => e.CustomerSurname).NotEmpty();
            RuleFor(e => e.ScheduleID).NotEmpty();
        }
    }
}
