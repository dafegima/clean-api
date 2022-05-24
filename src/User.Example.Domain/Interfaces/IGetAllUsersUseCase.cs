using System.Collections.Generic;
using User.Example.Domain.Entities;

namespace User.Example.Domain.Interfaces
{
    public interface IGetAllUsersUseCase
    {
        IEnumerable<UserEntity> Execute();
    }
}
