using System.ComponentModel.DataAnnotations;

namespace Simple_Login_Reg.Models
{
    public class Register
    {
        [Required]
        [MinLength(2)]
        public string FirstName {get;set;}

        [Required]
        [MinLength(2)]
        public string LastName {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [MinLength(8)]
        public string Password {get;set;}

        [Required]
        // [Display(Confirm_PW = "Confirm Password")]
        // [Compare(string Password)]
        public string Confirm_PW {get;set;}
    }
}