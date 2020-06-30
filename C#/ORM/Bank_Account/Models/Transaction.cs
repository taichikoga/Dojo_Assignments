using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank_Account.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId {get;set;}

        [Required]
        public decimal Amount {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int UserId {get;set;}

        public User Creator {get;set;}
    }
}