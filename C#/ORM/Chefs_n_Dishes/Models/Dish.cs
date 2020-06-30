using System;
using System.ComponentModel.DataAnnotations;

namespace Chefs_n_Dishes.Models
{
    public class Dish
    {
        [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int DishId { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Name of Dish")]
        public string DishName { get; set; }

        [Required(ErrorMessage = "is required")]
        [Display(Name = "# of Calories")]
        [Range(0,10000)]
        public int Calories { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 10 characters")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Range(1,5)]
        public int Tastiness {get;set;}

        [Required]
        [Display(Name = "Chef")]
        public int UserId {get;set;}

        public User Chef {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}