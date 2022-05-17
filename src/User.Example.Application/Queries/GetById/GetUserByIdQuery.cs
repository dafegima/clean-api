using User.Example.Domain.Entities;
using MediatR;

namespace User.Example.Application.Queries.GetById
{
    public class GetUserByIdQuery : IRequest<UserEntity>
    {
        public GetUserByIdQuery(string identification)
        {
            Identification = identification;
        }

        public string Identification { get; set; }
    }
}
