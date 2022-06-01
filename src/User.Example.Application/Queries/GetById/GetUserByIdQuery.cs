using User.Example.Domain.Entities;
using MediatR;

namespace User.Example.Application.Queries.GetById
{
    public class GetUserByIdQuery : IRequest<GetUserByIdQueryResponse>
    {
        public GetUserByIdQuery(string identification)
        {
            Identification = identification;
        }

        public string Identification { get; set; }
    }
}
