using User.Example.Application.Commands.UpdateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace User.Example.API.Endpoints.User
{
    [Route("api/users")]
    [Produces("application/json")]
    [ApiController]
    public class UpdateUserEndpoint : Controller
    {
        private readonly IMediator _mediator;
        public UpdateUserEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateUserCommand request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
