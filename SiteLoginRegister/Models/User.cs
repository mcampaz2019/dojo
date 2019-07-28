using System.ComponentModel.DataAnnotations;

namespace SiteLoginRegister.Models
{
    public class User
    {
        [Required]
        [MinLength(2)]
        [Display(Name= "First Name")]
        public string FirstName { get; set; }
        
        [Required]
        [MinLength(2)]
        [Display(Name= "Last Name")]
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress]
        [Display(Name= "Email Address")]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required]
        [MinLength(8)]
        [Compare("Password", ErrorMessage = "Please, enter a matching password!" ) ]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}