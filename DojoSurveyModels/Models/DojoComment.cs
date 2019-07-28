using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyModels.Models
{
    public class DojoComment
    {
        [Required(ErrorMessage = "Your Name is required") ]
        [MinLength(2, ErrorMessage = "Your Name must have more than 2 letters")]
        [Display(Name = "Your Name:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please, select a Dojo Location is required")]
        public string DojoLocation { get; set; }
        [Required(ErrorMessage = "Please, select your favorite language")]
        public string FavoriteLanguage { get; set; }
        [OptionalLength]
        public string Comment { get; set; }
    }
}