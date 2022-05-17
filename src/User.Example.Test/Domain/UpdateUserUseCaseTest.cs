using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using User.Example.Domain.Entities;
using User.Example.Domain.Interfaces;
using User.Example.Domain.UseCases;

namespace User.Example.Test.Domain
{
    public class UpdateUserUseCaseTest
    {
        private UpdateUserUseCase updateUserUseCase;

        [Test]
        public void Should_Return_User_Entity_Updated()
        {
            //ARRANGE
            UserEntity userEntity = new UserEntity() { Identification = "1", FirstName = "User", LastName = "Example" };
            var repo = new Mock<IUserRepository>();
            repo.Setup(m => m.GetById("1")).Returns(userEntity);
            repo.Setup(m => m.Update(userEntity)).Returns(userEntity);
            updateUserUseCase = new UpdateUserUseCase(repo.Object);

            //ACTION 
            var result = updateUserUseCase.Execute(userEntity);

            //ASSERT
            Assert.IsNotNull(result);
            Assert.AreEqual("1", result.Identification);
            Assert.AreEqual("User", result.FirstName);
            Assert.AreEqual("Example", result.LastName);
        }

        [Test]
        public void Should_Have_KeyNotFoundException()
        {
            //ARRANGE
            var repo = new Mock<IUserRepository>();
            repo.Setup(m => m.GetById("1")).Returns(new UserEntity());
            updateUserUseCase = new UpdateUserUseCase(repo.Object);

            //ACTION - //ASSERT
            Assert.Throws<KeyNotFoundException>(() => updateUserUseCase.Execute(new UserEntity() { Identification = "2" }));
        }
    }
}
