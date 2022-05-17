using User.Example.Application.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace User.Example.API.Endpoints.User
{
    [Route("api/users")]
    [Produces("application/json")]
    [ApiController]
    public class GetUserByIdEndpoint : Controller
    {
        private readonly IMediator _mediator;
        public GetUserByIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{identification}")]
        public async Task<IActionResult> Get(string identification)
        {
            var user = await _mediator.Send(new GetUserByIdQuery(identification));
            return Ok(user);

        }
    }
}
