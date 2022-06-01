using User.Example.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using User.Example.Domain.Interfaces;
using AutoMapper;

namespace User.Example.Application.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UpdateUserCommandResponse>
    {
        private readonly IUpdateUserUseCase _updateUserUseCase;
        private readonly IMapper _mapper;
        public UpdateUserCommandHandler(IUpdateUserUseCase updateUserUseCase, IMapper mapper)
        {
            _updateUserUseCase = updateUserUseCase;
            _mapper = mapper;
        }

        public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            UserEntity user = new UserEntity(request.Identification, request.NickName, request.FirstName, request.LastName, request.Genre, request.Email, request.BirthDate);
            _updateUserUseCase.Execute(user);
            return _mapper.Map<UpdateUserCommandResponse>(user);
        }
    }
}
