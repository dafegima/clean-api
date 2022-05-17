using User.Example.Domain.Entities;
using User.Example.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace User.Example.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly IUseCase<UserEntity, bool> _createUserUseCase;
        public CreateUserCommandHandler(IUseCase<UserEntity, bool> useCase)
        {
            _createUserUseCase = useCase;
        }

        public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            UserEntity user = new UserEntity(request.Identification, request.NickName, request.FirstName, request.LastName, request.Genre, request.Email, request.BirthDate);
            return _createUserUseCase.Execute(user);
        }
    }
}
