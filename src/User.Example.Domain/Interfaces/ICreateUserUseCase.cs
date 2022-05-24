using User.Example.Domain.Entities;

namespace User.Example.Domain.Interfaces
{
    public interface ICreateUserUseCase
    {
        bool Execute(UserEntity user);
    }
}
