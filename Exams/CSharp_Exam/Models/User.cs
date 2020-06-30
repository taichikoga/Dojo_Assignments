using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharp_Exam.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

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
        public List<Exercise> CreatedExercises {get;set;}
        public List<Participate> Participatings {get;set;}

    }
}