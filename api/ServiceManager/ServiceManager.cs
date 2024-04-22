using api.Data;
using api.Features.Authentication.Repository;
using api.Features.Users.Repository;

namespace api.ServiceManager
{
    public class ServiceManager : IServiceManager
    {
        private readonly DataContext _context;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IAuthenticationRepository> _authenticationRepository;

        public ServiceManager(DataContext context)
        {
            _context = context;
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_context));
            _authenticationRepository = new Lazy<IAuthenticationRepository>(() => new AuthenticationRepository(_context));
        }

        public IUserRepository UserRepository => _userRepository.Value;

        public IAuthenticationRepository AuthenticationRepository => _authenticationRepository.Value;

        public Task SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
