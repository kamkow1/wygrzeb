using System.ComponentModel.DataAnnotations;

namespace wygrzebforum.Models.CustomDataValidators
{
    public class EmailFieldValidator : ValidationAttribute
    {
        public string StringValue { get; set; }

        public string Message { get; set; }

        public EmailFieldValidator(string strval)
        {
            StringValue = strval;
        }

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            value = StringValue;

            if (!value.ToString().Contains('@'))
            {
                return new ValidationResult(Message,
                new[] { validationContext.MemberName });
            }

            return null;
        }
    }
}
