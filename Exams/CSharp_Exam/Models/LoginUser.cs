using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharp_Exam.Models
{
    [NotMapped]
    public class LoginUser
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string LoginEmail {get;set;}

        [Required]
        [MinLength(8, ErrorMessage = "Invalid Email or Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string LoginPassword {get;set;}
    }
}