using User.Example.Domain.Entities;

namespace User.Example.Domain.Interfaces
{
    public interface IUpdateUserUseCase
    {
        UserEntity Execute(UserEntity user);
    }
}
