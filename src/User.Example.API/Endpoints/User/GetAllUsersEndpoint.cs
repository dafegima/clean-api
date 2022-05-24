using User.Example.Application.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace User.Example.API.Endpoints.User
{
    [Tags("User")]
    [Route("api/users")]
    [Produces("application/json")]
    [ApiController]
    public class GetAllUsersEndpoint : Controller
    {
        private readonly IMediator _mediator;
        public GetAllUsersEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _mediator.Send(new GetAllUsersQuery());
            return Ok(users);
        }
    }
}
