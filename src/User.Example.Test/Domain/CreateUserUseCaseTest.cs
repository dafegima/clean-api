using Moq;
using NUnit.Framework;
using User.Example.Domain.Entities;
using User.Example.Domain.Exceptions;
using User.Example.Domain.Interfaces;
using User.Example.Domain.UseCases;

namespace User.Example.Test.Domain
{
    public class CreateUserUseCaseTest
    {
        private CreateUserUseCase createUserUseCase;

        [Test]
        public void Should_Have_Conflict_Exception()
        {
            //ARRANGE
            var repo = new Mock<IUserRepository>();
            repo.Setup(m => m.GetById("1")).Returns(new UserEntity());
            createUserUseCase = new CreateUserUseCase(repo.Object);

            //ACTION - //ASSERT
            Assert.Throws<ConflictException>(() => createUserUseCase.Execute(new UserEntity() { Identification = "1" }));
        }

        [Test]
        public void Should_Not_Have_Errors()
        {
            //ARRANGE
            var repo = new Mock<IUserRepository>();
            repo.Setup(m => m.GetById("1"));
            createUserUseCase = new CreateUserUseCase(repo.Object);

            //ACTION
            var result = createUserUseCase.Execute(new UserEntity() { Identification = "1" });

            //ASSERT
            Assert.AreEqual(true, result);
        }
    }
}
