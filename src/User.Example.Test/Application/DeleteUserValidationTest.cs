using FluentValidation.TestHelper;
using NUnit.Framework;
using User.Example.Application.Commands.DeleteUser;

namespace User.Example.Test.Application
{
    public class DeleteUserValidationTest
    {
        private DeleteUserCommandValidator deleteUserValidator;
        [SetUp]
        public void Setup()
        {
            deleteUserValidator = new DeleteUserCommandValidator();
        }

        [Test]
        public void Should_Have_Error_When_Id_Is_Empty()
        {
            var model = new DeleteUserCommand() { Identification = string.Empty };

            var result = deleteUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Identification);
        }

        [Test]
        public void Should_Have_Error_When_Id_Is_Too_Large()
        {
            var model = new DeleteUserCommand() { Identification = "123456789012345678901" };

            var result = deleteUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Identification);
        }

        [Test]
        public void Should_Not_Have_Error_When_Id_Is_Correct()
        {
            var model = new DeleteUserCommand() { Identification = "12345678901234567890" };

            var result = deleteUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.Identification);
        }
    }
}
