using User.Example.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace User.Example.Application.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            if (!UserExist(request.Identification))
                throw new KeyNotFoundException($"User with id {request.Identification} does not exist.");

            return _userRepository.Delete(request.Identification);
        }

        private bool UserExist(string identification)
        {
            return _userRepository.GetById(identification) != null;
        }
    }
}
