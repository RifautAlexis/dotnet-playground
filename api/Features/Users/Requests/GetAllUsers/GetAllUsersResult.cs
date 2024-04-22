using api.Domain;

namespace api.Features.Users.Requests.GetAllUsers
{
    public class GetAllUsersResult
    {
        public Guid Id { get; set; }
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public required string Email { get; set; }
        public Position Position { get; set; } = Position.Developer;
    }
}
