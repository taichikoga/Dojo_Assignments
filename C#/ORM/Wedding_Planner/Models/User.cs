using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wedding_Planner.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match")]
        public string PasswordConfirm { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Wedding> Weddings {get;set;}

        public List<Attend> Attendings {get;set;}

        public string FullName()
        {
            return FirstName+" "+LastName;
        }
    }
}