﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBlazorProject.Shared.Models.HR_Data
{
    [Table("HR_Designation")]
    public class HR_Designation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Designation Name")]
        public string? Name { get; set; }

    }
}
