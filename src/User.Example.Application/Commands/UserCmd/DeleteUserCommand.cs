using MediatR;

namespace User.Example.Application.Commands.UserCmd
{
    public class DeleteUserCommand : IRequest<bool>
    {
        public DeleteUserCommand(string identification)
        {
            Identification = identification;
        }
        public string Identification { get; set; }
    }
}
