using User.Example.Domain.Entities;
using User.Example.Domain.Exceptions;
using User.Example.Domain.Interfaces;

namespace User.Example.Domain.UseCases
{
    public class CreateUserUseCase : IUseCase<UserEntity, bool>
    {
        private readonly IUserRepository _userRepository;
        public CreateUserUseCase(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public override bool Execute(UserEntity request)
        {
            if (UserExist(request.Identification))
                throw new ConflictException($"User with id {request.Identification} already exist");

            UserEntity user = new UserEntity(request.Identification, request.NickName, request.FirstName, request.LastName, request.Genre, request.Email, request.BirthDate);
            _userRepository.Add(user);

            return true;
        }
    }
}
