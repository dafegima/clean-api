using FluentValidation;

namespace User.Example.Application.Commands.CreateUser
{
    public sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.Identification).NotEmpty().MaximumLength(20);
            RuleFor(x => x.NickName).NotEmpty().MaximumLength(30);
            RuleFor(x => x.FirstName).NotEmpty().MaximumLength(80);
            RuleFor(x => x.LastName).NotEmpty().MaximumLength(80);
            RuleFor(x => x.Email).NotEmpty().Matches(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
            RuleFor(x => x.Genre).NotEmpty().Matches("^(?:m|M|f|F)$");
            RuleFor(x => x.BirthDate).NotEmpty();
        }
    }
}
