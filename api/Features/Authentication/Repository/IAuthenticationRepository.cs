using api.Domain;

namespace api.Features.Authentication.Repository
{
    public interface IAuthenticationRepository
    {
        Task<User?> GetUser(string email, string password);
    }
}
