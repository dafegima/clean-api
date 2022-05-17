using System;

namespace User.Example.Domain.Entities
{
    public class UserEntity
    {
        public UserEntity() { }
        public UserEntity(string identification, string nickName, string firstName, string lastName, string genre, string email, DateTime birthDate)
        {
            Identification = identification;
            NickName = nickName;
            FirstName = firstName;
            LastName = lastName;
            Genre = genre;
            Email = email;
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
