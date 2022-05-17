using FluentValidation;

namespace User.Example.Application.Commands.DeleteUser
{
    public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
    {
        public DeleteUserCommandValidator()
        {
            RuleFor(x => x.Identification).NotEmpty();
        }
    }
}
