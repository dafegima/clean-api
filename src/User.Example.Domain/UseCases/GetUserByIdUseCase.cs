using System.Collections.Generic;
using User.Example.Domain.Entities;
using User.Example.Domain.Interfaces;

namespace User.Example.Domain.UseCases
{
    public class GetUserByIdUseCase : Base, IGetUserByIdUseCase
    {
        private readonly IUserRepository _userRepository;
        public GetUserByIdUseCase(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public UserEntity Execute(string identification)
        {
            return _userRepository.GetById(identification) ?? throw new KeyNotFoundException($"User with id {identification} does not exist.");
            
        }
    }
}
