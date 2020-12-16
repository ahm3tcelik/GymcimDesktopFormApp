using FluentValidation;
using Gymcim.Entities.Concrete;

namespace Gymcim.DataAccess.ValidationRules.FluentValidation
{
    public class PartValidator : AbstractValidator<Part>
    {
        public PartValidator()
        {
            RuleFor(e => e.PartID).NotEmpty();
            RuleFor(e => e.PartName).NotEmpty();
        }
    }
}
