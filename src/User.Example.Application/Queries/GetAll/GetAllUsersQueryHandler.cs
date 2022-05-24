using User.Example.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using User.Example.Domain.Interfaces;

namespace User.Example.Application.Queries.GetAll
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserEntity>>
    {
        private readonly IGetAllUsersUseCase _getAllUsersUseCase;
        public GetAllUsersQueryHandler(IGetAllUsersUseCase getAllUsersUseCase)
        {
            _getAllUsersUseCase = getAllUsersUseCase;
        }

        public async Task<IEnumerable<UserEntity>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return _getAllUsersUseCase.Execute();
        }
    }
}
