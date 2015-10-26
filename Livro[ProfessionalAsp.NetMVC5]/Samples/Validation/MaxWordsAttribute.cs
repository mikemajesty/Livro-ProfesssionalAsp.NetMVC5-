using System;
using System.ComponentModel.DataAnnotations;

namespace Livro_ProfessionalAsp.NetMVC5_.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class MaxWords : ValidationAttribute
    {
        public MaxWords(int maxWords)
            :base("{0} has too many words.")
        {
            _maxWords = maxWords;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var valueAsString = value.ToString();
                if (valueAsString.Length > _maxWords)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;
        }

        private readonly int _maxWords;
    }
}
