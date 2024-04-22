using api.Domain;
using api.ServiceManager;
using MediatR;

namespace api.Features.Authentication.Requests.Register
{
    public class RegisterHandler(IServiceManager serviceManager) : IRequestHandler<RegisterCommand, RegisterResult>
    {
        private readonly IServiceManager _serviceManager = serviceManager;

        public async Task<RegisterResult> Handle(RegisterCommand query, CancellationToken cancellationToken)
        {

            var user = await _serviceManager.AuthenticationRepository.GetUser(query.Email);

            if (user != null)
            {
                throw new Exception();
            }

            var newUser = new User
            {
                Id = Guid.NewGuid(),
                Firstname = query.Firstname,
                Lastname = query.Lastname,
                Email = query.Email,
                Password = query.Password,
                Age = query.Age,
            };

            await _serviceManager.AuthenticationRepository.AddUser(newUser);

            await _serviceManager.SaveAsync();

            return new RegisterResult
            {
                Jwt = "I am a jwt Token",
            };
        }
    }
}
