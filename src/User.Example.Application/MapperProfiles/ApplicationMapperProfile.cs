using AutoMapper;
using User.Example.Application.Commands.CreateUser;
using User.Example.Application.Commands.UpdateUser;
using User.Example.Application.Queries.GetAll;
using User.Example.Application.Queries.GetById;
using User.Example.Domain.Entities;

namespace User.Example.Application.MapperProfiles
{
    public class ApplicationMapperProfile : Profile
    {
        public ApplicationMapperProfile()
        {
            CreateMap<UserEntity, GetUserByIdQueryResponse>();
            CreateMap<UserEntity, GetAllUsersQueryResponse>();
            CreateMap<UserEntity, CreateUserCommandResponse>();
            CreateMap<UserEntity, UpdateUserCommandResponse>();
        }
    }
}
