using User.Example.Domain.Entities;
using User.Example.Domain.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace User.Example.Application.Queries.GetAll
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserEntity>>
    {
        private readonly IUseCase<string, IEnumerable<UserEntity>> _getAllUsersUseCase;
        public GetAllUsersQueryHandler(IUseCase<string, IEnumerable<UserEntity>> useCase)
        {
            _getAllUsersUseCase = useCase;
        }

        public async Task<IEnumerable<UserEntity>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return _getAllUsersUseCase.Execute(string.Empty);
        }
    }
}
