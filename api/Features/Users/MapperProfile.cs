using api.Domain;
using api.Features.Users.Requests.GetAllUsers;
using AutoMapper;

namespace api.Features.Users
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, GetAllUsersResult>();
        }
    }
}
