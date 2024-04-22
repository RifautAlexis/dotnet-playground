using MediatR;

namespace api.Features.Authentication.Requests.SignIn
{
    public class SignInCommand : IRequest<SignInResult>
    {
        public required string email { get; set; }
        public required string password { get; set; }
    }
}
