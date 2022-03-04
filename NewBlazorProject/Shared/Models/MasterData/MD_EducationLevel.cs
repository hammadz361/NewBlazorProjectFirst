using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewBlazorProject.Shared.Models.MasterData
{
    [Table("MD_EducationLevel")]
    public class MD_EducationLevel
    {
        [Key]
        public int? Id { get; set; }
        public string?  Name { get; set; }
    }
}
