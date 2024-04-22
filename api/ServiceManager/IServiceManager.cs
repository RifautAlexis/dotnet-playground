using api.Features.Authentication.Repository;
using api.Features.Users.Repository;

namespace api.ServiceManager
{
    public interface IServiceManager
    {
        IUserRepository UserRepository { get; }
        IAuthenticationRepository AuthenticationRepository { get; }
        Task SaveAsync();
    }
}
