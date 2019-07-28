using System.ComponentModel.DataAnnotations;

namespace SiteLoginRegister.Models
{
    public class LoginUser
    {        
        [Required]
        [EmailAddress]
        [Display(Name= "Email Address")]
        public string LoginEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }
}