using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyModels
{
    public class OptionalLengthAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((string)value == null || (string)value == "")
            {
                return ValidationResult.Success;            
            }
            else
            {
                if(((string)value).ToCharArray().Length < 20)
                {
                    return new ValidationResult("Your comment must have more than 20 characters!");            
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
        }
    }
}