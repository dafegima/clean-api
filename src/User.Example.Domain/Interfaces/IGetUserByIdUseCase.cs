using User.Example.Domain.Entities;

namespace User.Example.Domain.Interfaces
{
    public interface IGetUserByIdUseCase
    {
        UserEntity Execute(string identification);
    }
}
