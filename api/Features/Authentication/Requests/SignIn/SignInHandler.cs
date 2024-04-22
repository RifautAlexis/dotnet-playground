using api.ServiceManager;
using MediatR;

namespace api.Features.Authentication.Requests.SignIn
{
    public class SignInHandler(IServiceManager serviceManager) : IRequestHandler<SignInCommand, SignInResult>
    {
        private readonly IServiceManager _serviceManager = serviceManager;

        public async Task<SignInResult> Handle(SignInCommand query, CancellationToken cancellationToken)
        {

            var user = await _serviceManager.AuthenticationRepository.GetUser(query.email, query.password);

            if (user == null)
            {
                throw new Exception();
            }

            return new SignInResult
            {
                Jwt = "I am a jwt Token",
            };
        }
    }
}
