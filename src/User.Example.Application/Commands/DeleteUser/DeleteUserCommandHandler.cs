using User.Example.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace User.Example.Application.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly IUseCase<string, bool> _deleteUserUseCase;
        public DeleteUserCommandHandler(IUseCase<string, bool> useCase)
        {
            _deleteUserUseCase = useCase;
        }

        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            return _deleteUserUseCase.Execute(request.Identification);
        }
    }
}
