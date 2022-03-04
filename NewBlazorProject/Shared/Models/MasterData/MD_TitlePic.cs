using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlazorProject.Shared.Models.MasterData
{
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
