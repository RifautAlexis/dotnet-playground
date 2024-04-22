using api.Data;
using api.Domain;
using Microsoft.EntityFrameworkCore;

namespace api.Features.Authentication.Repository
{
    public class AuthenticationRepository(DataContext context) : IAuthenticationRepository
    {
        private readonly DataContext _context = context;
        public async Task<User?> GetUser(string email, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
        }
    }
}
