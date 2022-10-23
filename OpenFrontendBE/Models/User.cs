using OpenFrontendBE.Enums;
using System.ComponentModel.DataAnnotations;

namespace OpenFrontendBE.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }=String.Empty;

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public Role Role { get; set; }

        public UserProfile Profile { get; set; }
    }
}
