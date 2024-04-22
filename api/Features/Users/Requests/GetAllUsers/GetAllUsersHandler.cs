using api.Features.Users.Repository;
using api.ServiceManager;
using AutoMapper;
using MediatR;

namespace api.Features.Users.Requests.GetAllUsers
{
    public class GetAllUsersHandler(IServiceManager serviceManager, IMapper mapper) : IRequestHandler<GetAllUsersQuery, IEnumerable<GetAllUsersResult>>
    {
        private readonly IServiceManager _serviceManager = serviceManager;
        private readonly IMapper _mapper = mapper;

        public async Task<IEnumerable<GetAllUsersResult>> Handle(GetAllUsersQuery query, CancellationToken cancellationToken)
        {

            var users = await _serviceManager.UserRepository.GetAllAsync();

            if (users == null)
            {
                throw new Exception();
            }
            return _mapper.Map<IEnumerable<GetAllUsersResult>>(users);
        }
    }
}
