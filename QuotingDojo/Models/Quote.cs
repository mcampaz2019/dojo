using System;
using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models
{
    public class Quote
    {
        public Quote(string name, string quoteStatement)
        {
            Name = name;
            QuoteStatement = quoteStatement;
            PublicationDate = DateTime.Now;
        }
        [Required]
        [Display(Name="Your Name:")]
        public string Name { get; set; }
        [Required]
        [Display(Name="Your Quote:")]
        public string QuoteStatement { get; set; }
        
        public DateTime PublicationDate { get;  }

        // public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}