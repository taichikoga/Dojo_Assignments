using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chefs_n_Dishes.Models
{
    public class User
    {
        [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int UserId { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "is required")]
        [Display(Name = "Date of Birth")]
        public DateTime Birthday { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Dish> Dishes {get;set;}
    }
}