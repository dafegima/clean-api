namespace User.Example.Domain.Interfaces
{
    public abstract class IUseCase<TRequest, TResponse> where TRequest : class
    {
        private readonly IUserRepository _userRepository;
        public IUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public abstract TResponse Execute(TRequest request);

        public bool UserExist(string identification)
        {
            return _userRepository.GetById(identification) != null;
        }
    }
}
