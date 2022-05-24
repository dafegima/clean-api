using User.Example.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using User.Example.Domain.Interfaces;

namespace User.Example.Application.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UserEntity>
    {
        private readonly IUpdateUserUseCase _updateUserUseCase;
        public UpdateUserCommandHandler(IUpdateUserUseCase updateUserUseCase)
        {
            _updateUserUseCase = updateUserUseCase;
        }

        public async Task<UserEntity> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            UserEntity user = new UserEntity(request.Identification, request.NickName, request.FirstName, request.LastName, request.Genre, request.Email, request.BirthDate);
            return _updateUserUseCase.Execute(user);
        }
    }
}
