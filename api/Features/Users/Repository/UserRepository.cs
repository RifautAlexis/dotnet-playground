using api.Data;
using api.Domain;
using Microsoft.EntityFrameworkCore;

namespace api.Features.Users.Repository
{
    public class UserRepository(DataContext context) : IUserRepository
    {
        private readonly DataContext _context = context;

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
