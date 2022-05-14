using MediatR;
using System;
using User.Example.Domain.Entities;

namespace User.Example.Application.Commands.UserCmd
{
    public class UpdateUserCommand : IRequest<UserEntity>
    {
        public string Identification { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
