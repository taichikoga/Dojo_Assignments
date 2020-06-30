using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace The_Wall.Models
{
    public class Message
    {
        [Key]
        public int MessageId {get;set;}

        [Required]
        [MinLength(2)]
        [Display(Name = "Post a Message")]
        public string Body {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId {get;set;}

        public User Creator {get;set;}

        public List<Comment> CommentsOnMessage {get;set;}
    }
}