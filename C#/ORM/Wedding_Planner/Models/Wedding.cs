using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wedding_Planner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId {get;set;}

        [Required]
        [Display(Name = "Wedder One")]
        public string WedderOne {get;set;}

        [Required]
        [Display(Name = "Wedder Two")]
        public string WedderTwo {get;set;}

        [Required]
        public DateTime Date {get;set;}

        [Required]
        [Display(Name = "Wedding Address")]
        public string Address {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId {get;set;}

        public User Creator {get;set;}

        public List<Attend> Attendees {get;set;}
    }
}