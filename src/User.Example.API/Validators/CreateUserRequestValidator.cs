using FluentValidation;
using User.Example.API.Endpoints.User;

namespace User.Example.API.Validators
{
    public class CreateUserRequestValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserRequestValidator()
        {
            RuleFor(x => x.Age).NotEmpty().GreaterThan(0);
            RuleFor(x => x.BirthDate).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty().MaximumLength(80);
            RuleFor(x => x.Identification).NotEmpty().MaximumLength(20);
            RuleFor(x => x.LastName).NotEmpty().MaximumLength(80);
            RuleFor(x => x.NickName).NotEmpty().MaximumLength(30);
        }
    }
}
