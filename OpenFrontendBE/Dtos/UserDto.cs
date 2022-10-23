using System.ComponentModel.DataAnnotations;

namespace OpenFrontendBE.Dtos
{
    public class UserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}
