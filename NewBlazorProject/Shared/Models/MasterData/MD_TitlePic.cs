using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewBlazorProject.Shared.Models.MasterData
{
    [Table("MD_TitlePic")]
    public class MD_TitlePic
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Title path")]
        public string? Path { get; set; }
        [Required]
        [Display(Name = "Title Name")]
        public string? Name { get; set; }
    }
}
