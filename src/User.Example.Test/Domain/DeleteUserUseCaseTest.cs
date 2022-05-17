using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using User.Example.Domain.Entities;
using User.Example.Domain.Interfaces;
using User.Example.Domain.UseCases;

namespace User.Example.Test.Domain
{
    public class DeleteUserUseCaseTest
    {
        private DeleteUserUseCase deleteUserUseCase;

        [Test]
        public void Should_Not_Have_Errors()
        {
            //ARRANGE
            var repo = new Mock<IUserRepository>();
            repo.Setup(m => m.GetById("1")).Returns(new UserEntity());
            repo.Setup(m => m.Delete("1")).Returns(true);
            deleteUserUseCase = new DeleteUserUseCase(repo.Object);

            //ACTION 
            var result = deleteUserUseCase.Execute("1");

            //ASSERT
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Should_Have_KeyNotFoundException()
        {
            //ARRANGE
            var repo = new Mock<IUserRepository>();
            repo.Setup(m => m.GetById("1")).Returns(new UserEntity());
            deleteUserUseCase = new DeleteUserUseCase(repo.Object);

            //ACTION - //ASSERT
            Assert.Throws<KeyNotFoundException>(()=> deleteUserUseCase.Execute("2"));
        }
    }
}
