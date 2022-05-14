using MediatR;
using System;

namespace User.Example.Application.Commands.UserCmd
{
    public class CreateUserCommand : IRequest<bool>
    {
        public CreateUserCommand(string identification, string nickName, string firstName, string lastName, int age, DateTime birthDate)
        {
            Identification = identification;
            NickName = nickName;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            BirthDate = birthDate;
        }

        public string Identification { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
