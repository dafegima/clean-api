using User.Example.Application.Commands.UserCmd;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace User.Example.API.Endpoints.User
{
    [Route("api/users")]
    [Produces("application/json")]
    [ApiController]
    public class DeleteUserEndpoint : Controller
    {
        private readonly IMediator _mediator;
        public DeleteUserEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpDelete("{identification}")]
        public async Task<IActionResult> Delete(string identification)
        {
            var result = await _mediator.Send(new DeleteUserCommand(identification));
            return Ok();
        }
    }
}
