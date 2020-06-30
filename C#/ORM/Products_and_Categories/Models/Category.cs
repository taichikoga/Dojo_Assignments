using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products_and_Categories.Models
{
    public class Category
    {
        [Key]
        public int CategoryId {get;set;}

        [Required]
        [MaxLength(45)]
        public string Name {get;set;}

        public List<Association> ProductInCategory {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}