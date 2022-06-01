using System;
using User.Example.Application.Base;

namespace User.Example.Application.Queries.GetAll
{
    public class GetAllUsersQueryResponse : UserModel
    {
        public GetAllUsersQueryResponse(string identification, string nickName, string firstName, string lastName, string genre, string email, DateTime birthDate)
        {
            Identification = identification;
            NickName = nickName;
            FirstName = firstName;
            LastName = lastName;
            Genre = genre;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
