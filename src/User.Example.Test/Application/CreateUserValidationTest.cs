using FluentValidation.TestHelper;
using NUnit.Framework;
using User.Example.Application.Commands.CreateUser;

namespace User.Example.Test.Application
{
    public class CreateUserValidationTest
    {
        private CreateUserCommandValidator createUserValidator;
        [SetUp]
        public void Setup()
        {
            createUserValidator = new CreateUserCommandValidator();
        }

        [Test]
        public void Should_Have_Error_When_Id_Is_Empty()   
        {
            var model = new CreateUserCommand() { Identification = null};

            var result = createUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Identification);
        }

        [Test]
        public void Should_Have_Error_When_Id_Is_Too_Large()
        {
            var model = new CreateUserCommand() { Identification = "123465789012345678901" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Identification);
        }

        [Test]
        public void Should_Not_Have_Error_When_Id_Is_Correct()
        {
            var model = new CreateUserCommand() { Identification = "1234657890" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.Identification);
        }

        [Test]
        public void Should_Have_Error_When_Email_Is_Empty()
        {
            var model = new CreateUserCommand() { Email = "" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Email);
        }

        [Test]
        public void Should_Have_Error_When_Email_Has_Incorrect_Format_1()
        {
            var model = new CreateUserCommand() { Email = "da" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Email);
        }

        [Test]
        public void Should_Have_Error_When_Email_Has_Incorrect_Format_2()
        {
            var model = new CreateUserCommand() { Email = "da@" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Email);
        }

        [Test]
        public void Should_Have_Error_When_Email_Has_Incorrect_Format_3()
        {
            var model = new CreateUserCommand() { Email = "da@1." };

            var result = createUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Email);
        }

        [Test]
        public void Should_Have_Error_When_Email_Has_Incorrect_Format_4()
        {
            var model = new CreateUserCommand() { Email = "da@1.c" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Email);
        }

        [Test]
        public void Should_Not_Have_Error_When_Email_Is_Correct()
        {
            var model = new CreateUserCommand() { Email = "userapi@example.com" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.Email);
        }

        [Test]
        public void Should_Have_Error_When_FirstName_Is_Empty()
        {
            var model = new CreateUserCommand() { FirstName = string.Empty };

            var result = createUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.FirstName);
        }

        [Test]
        public void Should_Have_Error_When_FirstName_Is_Too_Large()
        {
            var model = new CreateUserCommand() { FirstName = "123456789012345678901234567890123456798012345679801324567980123465789012346578901" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.FirstName);
        }

        [Test]
        public void Should_Not_Have_Error_When_FirstName_Is_Correct()
        {
            var model = new CreateUserCommand() { FirstName = "User Example" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.FirstName);
        }

        [Test]
        public void Should_Have_Error_When_LastName_Is_Empty()
        {
            var model = new CreateUserCommand() { LastName = string.Empty };

            var result = createUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.LastName);
        }

        [Test]
        public void Should_Have_Error_When_LastName_Is_Too_Large()
        {
            var model = new CreateUserCommand() { LastName = "123456789012345678901234567890123456798012345679801324567980123465789012346578901" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.LastName);
        }

        [Test]
        public void Should_Not_Have_Error_When_LastName_Is_Correct()
        {
            var model = new CreateUserCommand() { LastName = "User Example" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.LastName);
        }

        [Test]
        public void Should_Have_Error_When_Genre_Is_Empty()
        {
            var model = new CreateUserCommand() { Genre = string.Empty };

            var result = createUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Genre);
        }

        [Test]
        public void Should_Have_Error_When_Genre_Different_To_M_F()
        {
            var model = new CreateUserCommand() { Genre = "A" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.Genre);
        }

        [Test]
        public void Should_Not_Have_Error_When_Genre_Equal_To_M()
        {
            var model = new CreateUserCommand() { Genre = "M" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.Genre);
        }

        [Test]
        public void Should_Not_Have_Error_When_Genre_Equal_To_m()
        {
            var model = new CreateUserCommand() { Genre = "m" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.Genre);
        }

        [Test]
        public void Should_Not_Have_Error_When_Genre_Equal_To_F()
        {
            var model = new CreateUserCommand() { Genre = "F" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.Genre);
        }

        [Test]
        public void Should_Not_Have_Error_When_Genre_Equal_To_f()
        {
            var model = new CreateUserCommand() { Genre = "f" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.Genre);
        }

        [Test]
        public void Should_Have_Error_When_NickName_Is_Empty()
        {
            var model = new CreateUserCommand() { NickName = string.Empty };

            var result = createUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.NickName);
        }

        [Test]
        public void Should_Have_Error_When_NickName_Is_Too_Large()
        {
            var model = new CreateUserCommand() { NickName = "1234567890123456789012345678901" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(user => user.NickName);
        }

        [Test]
        public void Should_Not_Have_Error_When_NickName_Is_Correct()
        {
            var model = new CreateUserCommand() { NickName = "123456789012345678901234567890" };

            var result = createUserValidator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(user => user.NickName);
        }
    }
}