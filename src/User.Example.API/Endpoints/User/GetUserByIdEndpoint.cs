using User.Example.Application.Queries.GetById;
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
    public class GetUserByIdEndpoint : Controller
    {
        private readonly IMediator _mediator;
        public GetUserByIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.BadRequest)]
        [SwaggerResponse((int)HttpStatusCode.NotFound)]
        [HttpGet("{identification}")]
        public async Task<IActionResult> Get(string identification)
        {
            var result = await _mediator.Send(new GetUserByIdQuery(identification));
            return Ok(result);
        }
    }
}
