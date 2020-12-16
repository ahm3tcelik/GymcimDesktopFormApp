using FluentValidation;
using Gymcim.Entities.Concrete;

namespace Gymcim.DataAccess.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(e => e.UserName).NotEmpty();
            RuleFor(e => e.UserMail).NotEmpty();
            RuleFor(e => e.UserPassword).NotEmpty();
            RuleFor(e => e.AccessFlags).NotEmpty();
        }
    }
}
