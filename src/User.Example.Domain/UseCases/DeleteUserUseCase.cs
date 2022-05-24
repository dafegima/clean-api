using System.Collections.Generic;
using User.Example.Domain.Interfaces;

namespace User.Example.Domain.UseCases
{
    public class DeleteUserUseCase : Base, IDeleteUserUseCase
    {
        private readonly IUserRepository _userRepository;
        public DeleteUserUseCase(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public bool Execute(string identification)
        {
            if (!UserExist(identification))
                throw new KeyNotFoundException($"User with id {identification} does not exist.");

            return _userRepository.Delete(identification);
        }
    }
}
