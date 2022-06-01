using User.Example.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using User.Example.Domain.Interfaces;
using AutoMapper;

namespace User.Example.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserCommandResponse>
    {
        private readonly ICreateUserUseCase _createUserUseCase;
        private readonly IMapper _mapper;
        public CreateUserCommandHandler(ICreateUserUseCase createUserUseCase, IMapper mapper)
        {
            _createUserUseCase = createUserUseCase;
            _mapper = mapper;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            UserEntity user = new UserEntity(request.Identification, request.NickName, request.FirstName, request.LastName, request.Genre, request.Email, request.BirthDate);
            _createUserUseCase.Execute(user);
            return _mapper.Map<CreateUserCommandResponse>(user);
        }
    }
}
