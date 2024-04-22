using MediatR;
using Microsoft.AspNetCore.Mvc;
using api.Features.Users.Requests.GetAllUsers;

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

        [HttpGet(Name = "GetAllUsers")]
        public async Task<ActionResult<IEnumerable<GetAllUsersResult>>> GetUsers()
        {
            var query = new GetAllUsersQuery
            {
            };

            var result = await _mediator.Send(query);

            return Ok(result);
        }
    }
}
