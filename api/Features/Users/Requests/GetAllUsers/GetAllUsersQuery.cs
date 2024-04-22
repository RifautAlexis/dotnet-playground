using MediatR;

namespace api.Features.Users.Requests.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<IEnumerable<GetAllUsersResult>>
    {
    }
}
