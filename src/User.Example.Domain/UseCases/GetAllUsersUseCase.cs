using System.Collections.Generic;
using User.Example.Domain.Entities;
using User.Example.Domain.Interfaces;

namespace User.Example.Domain.UseCases
{
    public class GetAllUsersUseCase : IUseCase<string, IEnumerable<UserEntity>>
    {
        private readonly IUserRepository _userRepository;
        public GetAllUsersUseCase(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public override IEnumerable<UserEntity> Execute(string request)
        {
            return _userRepository.GetAll();
        }
    }
}
