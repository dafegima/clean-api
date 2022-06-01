using System;
using User.Example.Application.Base;

namespace User.Example.Application.Queries.GetById
{
    public class GetUserByIdQueryResponse : UserModel
    {
        public GetUserByIdQueryResponse(string identification, string nickName, string firstName, string lastName, string genre, string email, DateTime birthDate)
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
