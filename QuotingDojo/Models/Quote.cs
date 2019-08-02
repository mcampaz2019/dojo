using System;
using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models
{
    public class Quote
    {
        [Required]
        [Display(Name="Your Name:")]
        public string UserName { get; set; }
        [Required]
        [Display(Name="Your Quote:")]
        public string QuoteStatement { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}