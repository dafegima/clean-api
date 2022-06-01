using User.Example.Application.Commands.UpdateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Net;
using Swashbuckle.AspNetCore.Annotations;

namespace User.Example.API.Endpoints.User
{
    [Tags("User")]
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

        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.BadRequest)]
        [SwaggerResponse((int)HttpStatusCode.NotFound)]
        [HttpPut]
        public async Task<IActionResult> Put(UpdateUserCommand request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}
