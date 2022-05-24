using User.Example.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using User.Example.Domain.Interfaces;

namespace User.Example.Application.Queries.GetById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserEntity>
    {
        private readonly IGetUserByIdUseCase _getUserByIdUseCase;
        public GetUserByIdQueryHandler(IGetUserByIdUseCase getUserByIdUseCase)
        {
            _getUserByIdUseCase = getUserByIdUseCase;
        }

        public async Task<UserEntity> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return _getUserByIdUseCase.Execute(request.Identification);
        }
    }
}
