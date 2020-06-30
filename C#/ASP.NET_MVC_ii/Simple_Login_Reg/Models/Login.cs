using System.ComponentModel.DataAnnotations;

namespace Simple_Login_Reg.Models
{
    public class Login
    {

        [Required]
        [EmailAddress]
        public string LoginEmail {get;set;}

        [Required]
        public string LoginPassword {get;set;}
    }
}