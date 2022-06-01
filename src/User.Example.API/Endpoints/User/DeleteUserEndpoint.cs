using User.Example.Application.Commands.DeleteUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace User.Example.API.Endpoints.User
{
    [Tags("User")]
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

        [SwaggerResponse((int)HttpStatusCode.NoContent)]
        [SwaggerResponse((int)HttpStatusCode.BadRequest)]
        [SwaggerResponse((int)HttpStatusCode.NotFound)]
        [HttpDelete("{identification}")]
        public async Task<IActionResult> Delete(string identification)
        {
            await _mediator.Send(new DeleteUserCommand(identification));
            return NoContent();
        }
    }
}
