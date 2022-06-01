using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using User.Example.Domain.Interfaces;

namespace User.Example.Application.Queries.GetById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, GetUserByIdQueryResponse>
    {
        private readonly IGetUserByIdUseCase _getUserByIdUseCase;
        private readonly IMapper _mapper;
        public GetUserByIdQueryHandler(IGetUserByIdUseCase getUserByIdUseCase, IMapper mapper)
        {
            _getUserByIdUseCase = getUserByIdUseCase;
            _mapper = mapper;
        }

        public async Task<GetUserByIdQueryResponse> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = _getUserByIdUseCase.Execute(request.Identification);
            return _mapper.Map<GetUserByIdQueryResponse>(user);
        }
    }
}
