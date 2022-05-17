using User.Example.Domain.Entities;
using User.Example.Domain.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace User.Example.Application.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UserEntity>
    {
        private readonly IUserRepository _userRepository;
        public UpdateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserEntity> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            if (!UserExist(request.Identification))
                throw new KeyNotFoundException($"User with id {request.Identification} does not exist.");

            UserEntity user = new UserEntity(request.Identification, request.NickName, request.FirstName, request.LastName, request.Genre, request.Email, request.BirthDate);
            return _userRepository.Update(user);
        }

        private bool UserExist(string identification)
        {
            return _userRepository.GetById(identification) != null;
        }
    }
}
