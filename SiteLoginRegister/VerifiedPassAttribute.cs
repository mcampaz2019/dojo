using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission
{
    public class VerifiedPassAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (DateTime.Parse((string)value) > DateTime.Now)
            return new ValidationResult("Future Dates are not allowed!");
        return ValidationResult.Success;
    }
}
}