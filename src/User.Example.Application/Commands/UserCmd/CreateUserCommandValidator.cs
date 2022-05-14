using FluentValidation;

namespace User.Example.Application.Commands.UserCmd
{
    public sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.Identification).NotEmpty();
            RuleFor(x => x.NickName).NotEmpty().MaximumLength(30);
            RuleFor(x => x.FirstName).NotEmpty().MaximumLength(80);
            RuleFor(x => x.LastName).NotEmpty().MaximumLength(80);
            RuleFor(x => x.Age).NotEmpty().GreaterThan(0);
            RuleFor(x => x.BirthDate).NotEmpty();
        }
    }
}
