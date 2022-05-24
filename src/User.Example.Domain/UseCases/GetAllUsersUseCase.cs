using System.Collections.Generic;
using User.Example.Domain.Entities;
using User.Example.Domain.Interfaces;

namespace User.Example.Domain.UseCases
{
    public class GetAllUsersUseCase : IGetAllUsersUseCase
    {
        private readonly IUserRepository _userRepository;
        public GetAllUsersUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserEntity> Execute()
        {
            return _userRepository.GetAll();
        }
    }
}
