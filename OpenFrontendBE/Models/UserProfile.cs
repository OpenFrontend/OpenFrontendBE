using System.ComponentModel.DataAnnotations;

namespace OpenFrontendBE.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; } = String.Empty; 
        public string ImageUrl { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; }
        public int UploadCount { get; set; }
        public string Description { get; set; } = String.Empty;
        public string SocialUrl { get; set; } = String.Empty;

        public User User { get; set; }
        public int UserId { get; set; }


    }
}
