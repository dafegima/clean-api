using User.Example.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace User.Example.Application.Queries.GetAll
{
    public class GetAllUsersQuery : IRequest<IEnumerable<UserEntity>>
    {
    }
}
