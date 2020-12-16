using FluentValidation;
using Gymcim.Entities.Concrete;

namespace Gymcim.DataAccess.ValidationRules.FluentValidation
{
    public class ScheduleValidator : AbstractValidator<Schedule>
    {
        public ScheduleValidator()
        {
            RuleFor(e => e.ScheduleName).NotEmpty();
        }
    }
}
