using User.Example.Domain.Entities;
using User.Example.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using User.Example.Application.PipelineBehaviors;

namespace User.Example.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            if (UserExist(request.Identification))
                throw new ConflictException($"User with id {request.Identification} already exist");

            UserEntity user = new UserEntity(request.Identification, request.NickName, request.FirstName, request.LastName, request.Genre, request.Email, request.BirthDate);
            _userRepository.Add(user);

            return true;
        }

        private bool UserExist(string identification)
        {
            return _userRepository.GetById(identification) != null;
        }
    }
}
