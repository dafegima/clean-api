using User.Example.Domain.Entities;
using User.Example.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace User.Example.Application.Queries.GetById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserEntity>
    {
        private readonly IUseCase<string, UserEntity> _getUserByIdUseCase;
        public GetUserByIdQueryHandler(IUseCase<string, UserEntity> useCase)
        {
            _getUserByIdUseCase = useCase;
        }

        public async Task<UserEntity> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return _getUserByIdUseCase.Execute(request.Identification);
        }
    }
}
