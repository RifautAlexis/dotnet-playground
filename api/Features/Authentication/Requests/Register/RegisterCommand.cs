using api.Domain;
using MediatR;

namespace api.Features.Authentication.Requests.Register
{
    public class RegisterCommand : IRequest<RegisterResult>
    {
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public int? Age { get; set; }
    }
}
