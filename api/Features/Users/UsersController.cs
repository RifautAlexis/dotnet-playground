using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace api.Features.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetGamesForConsole")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var query = new GetUsersQuery
            {
            };

            var result = await _mediator.Send(query);

            return Ok(result);
        }
    }
}
