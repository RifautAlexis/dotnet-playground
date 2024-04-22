using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Domain
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required Guid Id { get; set; }
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public int? Age { get; set; }
        public Position Position { get; set; } = Position.Newcomer;
    }

    public enum Position
    {
        Hr,
        Manager,
        Developer,
        Newcomer,
    }
}
