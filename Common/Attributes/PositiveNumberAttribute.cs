using System.ComponentModel.DataAnnotations;

namespace DasofWebApp.Common.Attributes
{// Class for checking if number is valid
    public class PositiveNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is null )
            {
                return new ValidationResult("The value cannot be null.");
            }

            bool isValid = false;
            string errorMessage = "Value must be a positive number.";

            if (value is int intValue)
            {
                isValid = intValue >= 0;
            }
            else if (value is decimal decimalValue)
            {
                isValid = decimalValue >= 0;
            }
            else if (value is double doubleValue)
            {
                isValid = doubleValue >= 0;
            }

            return isValid ? ValidationResult.Success! : new ValidationResult(errorMessage)!;
        }
    }
}