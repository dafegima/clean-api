using User.Example.Domain.Entities;
using User.Example.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace User.Example.Application.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UserEntity>
    {
        private readonly IUseCase<UserEntity, UserEntity> _updateUserUseCase;
        public UpdateUserCommandHandler(IUseCase<UserEntity, UserEntity> useCase)
        {
            _updateUserUseCase = useCase;
        }

        public async Task<UserEntity> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            UserEntity user = new UserEntity(request.Identification, request.NickName, request.FirstName, request.LastName, request.Genre, request.Email, request.BirthDate);
            return _updateUserUseCase.Execute(user);
        }
    }
}
