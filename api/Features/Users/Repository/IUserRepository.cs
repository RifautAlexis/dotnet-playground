using api.Domain;

namespace api.Features.Users.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
    }
}
