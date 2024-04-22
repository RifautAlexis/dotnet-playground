using api.Features.Authentication.Requests.Register;
using api.Features.Authentication.Requests.SignIn;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace api.Features.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthenticationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("SignIn")]
        public async Task<ActionResult<Requests.SignIn.SignInResult>> SignIn(SignInCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPost("Register")]
        public async Task<ActionResult<RegisterResult>> SignIn(RegisterCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
