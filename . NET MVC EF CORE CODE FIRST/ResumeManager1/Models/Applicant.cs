﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeManager.Models
{
    public class Applicant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; } = "";

        [Required]
        [Range(25,55,ErrorMessage ="Currently, We Have no Positions Vacant for Your Age")]
        [DisplayName("Age in Years")]
        public int Age { get; set; }

        [Required]
        [StringLength(50)]
        public string Qualification { get; set; } = "";

        [Required]
        [Range(1,25,ErrorMessage ="Currently, We Have no Position Vacant for Your Experience")]
        [DisplayName("Total Experience in Years")]
        public int TotalExperiemce { get; set; }

        public virtual List<Experience> Experiences { get; set; } = new List<Experience>();//detail very inportant

        public string PhotoUrl { get; set; }

        [Required(ErrorMessage = "Please Choose the Profile Photo")]
        [Display(Name ="Profile Photo")]
        [NotMapped]

        public IFormFile ProfilePhoto { get; set; }
    }
}
