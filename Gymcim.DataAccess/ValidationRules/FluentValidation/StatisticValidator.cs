using FluentValidation;
using Gymcim.Entities.Concrete;

namespace Gymcim.DataAccess.ValidationRules.FluentValidation
{
    public class StatisticValidator : AbstractValidator<Statistic>
    {
        public StatisticValidator()
        {
            RuleFor(e => e.StatisticDate).NotEmpty();
        }
    }
}
