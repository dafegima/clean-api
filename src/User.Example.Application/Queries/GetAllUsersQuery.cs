using User.Example.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace User.Example.Application.Queries
{
    public class GetAllUsersQuery : IRequest<IEnumerable<UserEntity>>
    {
    }
}
