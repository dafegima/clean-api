using User.Example.Domain.Interfaces;

namespace User.Example.Domain.UseCases
{
    public class Base
    {
        private readonly IUserRepository _userRepository;
        public Base(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool UserExist(string identification)
        {
            return _userRepository.GetById(identification) != null;
        }
    }
}
