using User.Example.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using User.Example.Domain.Interfaces;

namespace User.Example.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly ICreateUserUseCase _createUserUseCase;
        public CreateUserCommandHandler(ICreateUserUseCase createUserUseCase)
        {
            _createUserUseCase = createUserUseCase;
        }

        public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            UserEntity user = new UserEntity(request.Identification, request.NickName, request.FirstName, request.LastName, request.Genre, request.Email, request.BirthDate);
            return _createUserUseCase.Execute(user);
        }
    }
}
