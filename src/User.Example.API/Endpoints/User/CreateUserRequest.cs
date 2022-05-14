using System;

namespace User.Example.API.Endpoints.User
{
    public class CreateUserRequest
    {
        public string Identification { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
