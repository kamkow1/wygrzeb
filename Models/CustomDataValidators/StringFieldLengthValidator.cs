using System.ComponentModel.DataAnnotations;

namespace wygrzebforum.Models.CustomDataValidators
{
    public class StringFieldLengthValidator : ValidationAttribute
    {
        public int MaxLength { get; set; }

        public string Message { get; set; }

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            if (value.ToString().Length > MaxLength)
            {
                return new ValidationResult(Message ,
                new[] { validationContext.MemberName });
            }

            return null;
        }
    }
}
