using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading.Tasks;
using User.Example.Application.Commands.CreateUser;

namespace User.Example.API.Endpoints.User
{
    [Route("api/users")]
    [Produces("application/json")]
    [ApiController]
    public class CreateUserEndpoint : Controller
    {
        private readonly ISender _sender;
        private readonly IMediator _mediator;
        public CreateUserEndpoint(IMediator mediator, ISender sender)
        {
            _mediator = mediator;
            _sender = sender;
        }

        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.BadRequest)]
        [SwaggerResponse((int)HttpStatusCode.Conflict)]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserCommand request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
