using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace The_Wall.Models
{
    public class Comment
    {
        [Key]
        public int CommentId {get;set;}

        [Required]
        [MinLength(2)]
        [Display(Name = "Post a Comment")]
        public string CommentBody {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId {get;set;}

        public int MessageId {get;set;}

        public User User {get;set;}

        public Message Message {get;set;}
    }
}