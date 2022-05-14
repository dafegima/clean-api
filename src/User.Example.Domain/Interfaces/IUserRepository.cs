using User.Example.Domain.Entities;
using System.Collections.Generic;

namespace User.Example.Domain.Interfaces
{
    public interface IUserRepository
    {
        void Add(UserEntity user);
        UserEntity GetById(string identification);
        IEnumerable<UserEntity> GetAll();
        UserEntity Update(UserEntity user);
        bool Delete(string identification);
    }
}
