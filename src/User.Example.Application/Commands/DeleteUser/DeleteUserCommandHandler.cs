using MediatR;
using System.Threading;
using System.Threading.Tasks;
using User.Example.Domain.Interfaces;

namespace User.Example.Application.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly IDeleteUserUseCase _deleteUserUseCase;
        public DeleteUserCommandHandler(IDeleteUserUseCase deleteUserUseCase)
        {
            _deleteUserUseCase = deleteUserUseCase;
        }

        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            return _deleteUserUseCase.Execute(request.Identification);
        }
    }
}
