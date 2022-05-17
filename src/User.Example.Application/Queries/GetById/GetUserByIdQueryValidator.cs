using FluentValidation;

namespace User.Example.Application.Queries.GetById
{
    public class GetUserByIdQueryValidator : AbstractValidator<GetUserByIdQuery>
    {
        public GetUserByIdQueryValidator()
        {
            RuleFor(x => x.Identification).NotEmpty().MaximumLength(20);
        }
    }
}
