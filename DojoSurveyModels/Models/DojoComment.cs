using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyModels.Models
{
    public class DojoComment
    {
        [Required]
        [Display(Name = "Your Name:")]
        public string Name { get; set; }
        public string DojoLocation { get; set; }
        public string FavoriteLanguage { get; set; }
        public string Comment { get; set; }
    }
}