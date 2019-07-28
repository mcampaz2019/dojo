using System.ComponentModel.DataAnnotations;

namespace SiteLoginRegister.Models
{
    public class LoginUser
    {        
        [Required]
        [EmailAddress]
        [Display(Name= "Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}