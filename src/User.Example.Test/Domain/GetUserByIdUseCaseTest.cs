using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using User.Example.Domain.Entities;
using User.Example.Domain.Interfaces;
using User.Example.Domain.UseCases;

namespace User.Example.Test.Domain
{
    public class GetUserByIdUseCaseTest
    {
        private GetUserByIdUseCase getUserByIdUseCase;
        
        [Test]
        public void Should_Have_KeyNotFoundException()
        {
            //ARRANGE
            var repo = new Mock<IUserRepository>();
            repo.Setup(m => m.GetById("1"));
            getUserByIdUseCase = new GetUserByIdUseCase(repo.Object);

            //ACTION - //ASSERT
            Assert.Throws<KeyNotFoundException>(() => getUserByIdUseCase.Execute("1"));
        }

        [Test]
        public void Should_Return_User_Entity()
        {
            //ARRANGE
            var repo = new Mock<IUserRepository>();
            repo.Setup(m => m.GetById("1")).Returns(new UserEntity());
            getUserByIdUseCase = new GetUserByIdUseCase(repo.Object);

            //ACTION
            var result = getUserByIdUseCase.Execute("1");

            //ASSERT
            Assert.IsNotNull(result);
        }
    }
}
