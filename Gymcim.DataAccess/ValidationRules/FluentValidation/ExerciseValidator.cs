using FluentValidation;
using Gymcim.Entities.Concrete;

namespace Gymcim.DataAccess.ValidationRules.FluentValidation
{
    public class ExerciseValidator : AbstractValidator<Exercise>
    {
        public ExerciseValidator()
        {
            RuleFor(e => e.ExerciseName).NotEmpty();
            RuleFor(e => e.ExerciseDay).NotEmpty();
            RuleFor(e => e.PartID).NotEmpty();
            RuleFor(e => e.ScheduleID).NotEmpty();
        }
    }
}
