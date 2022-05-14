using System;

namespace User.Example.Domain.Entities
{
    public class UserEntity
    {
        public UserEntity(string identification, string nickName, string firtsName, string lastName, int age, DateTime birthDate)
        {
            Identification = identification;
            NickName = nickName;
            FirtsName = firtsName;
            LastName = lastName;
            Age = age;
            BirthDate = birthDate;
        }

        public string Identification { get; set; }
        public string NickName { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
