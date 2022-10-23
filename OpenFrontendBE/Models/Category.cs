using System.ComponentModel.DataAnnotations;

namespace OpenFrontendBE.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }=String.Empty;
        public int TotalCount { get; set; }

        public string Icon { get; set; }
    }
}
