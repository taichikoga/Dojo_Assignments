using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharp_Exam.Models
{
    public class Exercise
    {
        [Key]
        public int ExerciseId { get; set; }

        [Required]
        public string Title { get; set; }

        [Display(Name = "Date and Time")]
        public DateTime DateTime { get; set; }
        public int Duration { get; set; }

        [Display(Name = "Unit of Time")]
        public string UnitOfTime { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId {get;set;}

        public User Coordinator {get;set;}

        public List<Participate> Participants {get;set;}

    }
}