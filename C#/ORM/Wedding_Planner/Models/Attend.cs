using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wedding_Planner.Models
{
    public class Attend
    {
        [Key]
        public int AttendId {get;set;}
        public bool IsRSVPed {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int UserId {get;set;}
        public int WeddingId {get;set;}
        public User User {get;set;}
        public Wedding Wedding {get;set;}
    }
}