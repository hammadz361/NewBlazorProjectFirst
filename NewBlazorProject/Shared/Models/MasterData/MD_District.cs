using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewBlazorProject.Shared.Models
{
    [Table("MD_District")]
    public class MD_District
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "District Name")]
        public string? Name { get; set; }
    }
}
