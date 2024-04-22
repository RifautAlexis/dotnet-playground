using api.Data;
using api.Features.Users.Repository;

namespace api.ServiceManager
{
    public class ServiceManager : IServiceManager
    {
        private readonly DataContext _context;
        private readonly Lazy<IUserRepository> _userRepository;

        public ServiceManager(DataContext context)
        {
            _context = context;
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_context));
        }

        public IUserRepository UserRepository => _userRepository.Value;

        public Task SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
