using User.Example.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using User.Example.Domain.Interfaces;
using AutoMapper;
using System.Linq;

namespace User.Example.Application.Queries.GetAll
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<GetAllUsersQueryResponse>>
    {
        private readonly IGetAllUsersUseCase _getAllUsersUseCase;
        private readonly IMapper _mapper;
        public GetAllUsersQueryHandler(IGetAllUsersUseCase getAllUsersUseCase, IMapper mapper)
        {
            _getAllUsersUseCase = getAllUsersUseCase;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetAllUsersQueryResponse>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = _getAllUsersUseCase.Execute();
            return _mapper.Map<IEnumerable<GetAllUsersQueryResponse>>(users);
            
        }
    }
}
