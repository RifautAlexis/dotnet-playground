using api.Features.Users.Repository;

namespace api.ServiceManager
{
    public interface IServiceManager
    {
        IUserRepository UserRepository { get; }
        Task SaveAsync();
    }
}
