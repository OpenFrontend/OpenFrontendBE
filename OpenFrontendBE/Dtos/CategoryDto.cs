using System.ComponentModel.DataAnnotations;

namespace OpenFrontendBE.Dtos
{
    public class CategoryDto
    {
        
        [Required]
        public string CategoryName { get; set; }=String.Empty;
       
        [Required]
        public string Icon { get; set; }
    }
}
