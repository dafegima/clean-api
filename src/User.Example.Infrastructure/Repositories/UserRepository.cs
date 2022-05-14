using User.Example.Domain.Entities;
using User.Example.Domain.Interfaces;
using User.Example.Infrastructure.Settings;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace User.Example.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static List<UserEntity> users;
        private readonly DBSettings _settings;
        public UserRepository(IOptions<DBSettings> settings)
        {
            users = new List<UserEntity>();
            _settings = settings.Value ?? throw new ArgumentNullException(nameof(settings));
        }
        public void Add(UserEntity user)
        {
            users.Add(user);
        }

        public bool Delete(string identification)
        {
            users.Remove(users.Find(x => x.Identification == identification));
            return true;
        }

        public IEnumerable<UserEntity> GetAll()
        {
            return users;
        }

        public UserEntity GetById(string identification)
        {
            return users.Find(x => x.Identification == identification);
        }

        public UserEntity Update(UserEntity user)
        {
            users.Remove(users.Find(x => x.Identification == user.Identification));
            users.Add(user);

            return user;
        }
    }
}
