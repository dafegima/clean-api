using MediatR;
using System;

namespace User.Example.Application.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<bool>
    {
        public CreateUserCommand() { }
        public CreateUserCommand(string identification, string nickName, string firstName, string lastName, string email, string genre, DateTime birthDate)
        {
            Identification = identification;
            NickName = nickName;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Genre = genre;
            BirthDate = birthDate;
        }

        public string Identification { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Genre { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
