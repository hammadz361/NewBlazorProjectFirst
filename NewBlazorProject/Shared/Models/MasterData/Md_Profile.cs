using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NewBlazorProject.Shared.Models.MasterData
{
    [Table("MD_Profile")]
    public class Md_Profile
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "UserName")]
        public string? UserName { get; set; }
        [Required]
        [Display(Name = "FirstName")]
        public string? FirstName { get; set; }
        [Display(Name = "LastName")]
        public string? LastName { get; set; }
        [Required]
        [Display(Name = "cnic")]
        [DataType(DataType.CreditCard)]
        public string? cnic { get; set; }
        [Required]
        [Display(Name = "FatherName")]
        public string? FatherName { get; set; }
        [Required]
        [Display(Name = "Gender")]

        public int GenderId { get; set; }
        [ForeignKey("Gender")]
        public virtual MD_Gender? Gender { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string? Email { get; set; }
        [Required]
        [Display(Name = "PhoneNumber")]
        public string? PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Address")]
        
        public int? AddressId { get; set; }
        [ForeignKey("AddressId")]
        public virtual MD_Address? Address { get; set; }
        [Required]
        [Display(Name = "Education")]
        public int EducationId { get; set; }
        [ForeignKey("EducationId")]
        public virtual MD_Education? Education { get; set;}

        [Required]
        [Display(Name = "Posting")]
        public int PostingId { get; set; }
        [Required]
        [Display(Name = "Clearness")]
        public bool Clearness { get; set; }
        [Required]
        [Display(Name = "Date Of Birth")]
        public DateOnly dateOfBirth { get; set; }
        [Display(Name = "Select File")]
        public int Title_picId { get; set; }
        public virtual MD_TitlePic? Title_PicId { get; set; }
    }
}
