using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace The_Wall.Models
{
    [NotMapped]
    public class LoginUser
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string LoginEmail {get;set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string LoginPassword {get;set;}
    }
}