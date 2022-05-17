using FluentValidation.TestHelper;
using NUnit.Framework;
using User.Example.Application.Commands.UpdateUser;

namespace User.Example.Test.Application
{
    public class UpdateUserValidationTest
    {
        private UpdateUserCommandValidator updateUserValidator;
        [SetUp]
        public void Setup()
        {
            updateUserValidator = new UpdateUserCommandValidator();
        }

        [Test]
        public void Should_Have_Error_When_Id_Is_Emmpty()
        {
            var model = new UpdateUserCommand() { Identification = null };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Identification);
        }

        [Test]
        public void Should_Have_Error_When_Id_Is_Too_Large()
        {
            var model = new UpdateUserCommand() { Identification = "123465789012345678901" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Identification);
        }

        [Test]
        public void Should_Not_Have_Error_When_Id_Is_Correct()
        {
            var model = new UpdateUserCommand() { Identification = "1234657890" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.Identification);
        }

        [Test]
        public void Should_Have_Error_When_Email_Is_Empty()
        {
            var model = new UpdateUserCommand() { Email = "" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Email);
        }

        [Test]
        public void Should_Have_Error_When_Email_Has_Incorrect_Format_1()
        {
            var model = new UpdateUserCommand() { Email = "da" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Email);
        }

        [Test]
        public void Should_Have_Error_When_Email_Has_Incorrect_Format_2()
        {
            var model = new UpdateUserCommand() { Email = "da@" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Email);
        }

        [Test]
        public void Should_Have_Error_When_Email_Has_Incorrect_Format_3()
        {
            var model = new UpdateUserCommand() { Email = "da@1." };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Email);
        }

        [Test]
        public void Should_Have_Error_When_Email_Has_Incorrect_Format_4()
        {
            var model = new UpdateUserCommand() { Email = "da@1.c" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Email);
        }

        [Test]
        public void Should_Not_Have_Error_When_Email_Is_Correct()
        {
            var model = new UpdateUserCommand() { Email = "userapi@example.com" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.Email);
        }

        [Test]
        public void Should_Have_Error_When_FirstName_Is_Empty()
        {
            var model = new UpdateUserCommand() { FirstName = string.Empty };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.FirstName);
        }

        [Test]
        public void Should_Have_Error_When_FirstName_Is_Too_Large()
        {
            var model = new UpdateUserCommand() { FirstName = "123456789012345678901234567890123456798012345679801324567980123465789012346578901" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.FirstName);
        }

        [Test]
        public void Should_Not_Have_Error_When_FirstName_Is_Correct()
        {
            var model = new UpdateUserCommand() { FirstName = "User Example" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.FirstName);
        }

        [Test]
        public void Should_Have_Error_When_LastName_Is_Empty()
        {
            var model = new UpdateUserCommand() { LastName = string.Empty };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.LastName);
        }

        [Test]
        public void Should_Have_Error_When_LastName_Is_Too_Large()
        {
            var model = new UpdateUserCommand() { LastName = "123456789012345678901234567890123456798012345679801324567980123465789012346578901" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.LastName);
        }

        [Test]
        public void Should_Not_Have_Error_When_LastName_Is_Correct()
        {
            var model = new UpdateUserCommand() { LastName = "User Example" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.LastName);
        }

        [Test]
        public void Should_Have_Error_When_Genre_Is_Empty()
        {
            var model = new UpdateUserCommand() { Genre = string.Empty };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Genre);
        }

        [Test]
        public void Should_Have_Error_When_Genre_Different_To_M_F()
        {
            var model = new UpdateUserCommand() { Genre = "A" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Genre);
        }

        [Test]
        public void Should_Not_Have_Error_When_Genre_Equal_To_M()
        {
            var model = new UpdateUserCommand() { Genre = "M" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.Genre);
        }

        [Test]
        public void Should_Not_Have_Error_When_Genre_Equal_To_m()
        {
            var model = new UpdateUserCommand() { Genre = "m" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.Genre);
        }

        [Test]
        public void Should_Not_Have_Error_When_Genre_Equal_To_F()
        {
            var model = new UpdateUserCommand() { Genre = "F" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.Genre);
        }

        [Test]
        public void Should_Not_Have_Error_When_Genre_Equal_To_f()
        {
            var model = new UpdateUserCommand() { Genre = "f" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.Genre);
        }

        [Test]
        public void Should_Have_Error_When_NickName_Is_Empty()
        {
            var model = new UpdateUserCommand() { NickName = string.Empty };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.NickName);
        }

        [Test]
        public void Should_Have_Error_When_NickName_Is_Too_Large()
        {
            var model = new UpdateUserCommand() { NickName = "1234567890123456789012345678901" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.NickName);
        }

        [Test]
        public void Should_Not_Have_Error_When_NickName_Is_Correct()
        {
            var model = new UpdateUserCommand() { NickName = "123456789012345678901234567890" };

            var result = updateUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.NickName);
        }
    }
}