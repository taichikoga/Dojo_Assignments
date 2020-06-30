using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSharp_Exam.Models
{
    public class Participate
    {
        [Key]
        public int ParticipateId {get;set;}
        public bool IsParticipating {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int UserId {get;set;}
        public int ExerciseId {get;set;}
        public User User {get;set;}
        public Exercise Exercise {get;set;}
    }
}