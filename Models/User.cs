using System;
using System.ComponentModel.DataAnnotations;
using wygrzebforum.Models.CustomDataValidators;

namespace wygrzebforum.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "długość loginu musi być większa niż 0 znaków!")]
        [StringFieldLengthValidator(MaxLength = 20, ErrorMessage = "login nie może być dłuższy niż 20 znaków!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "długość hasła musi być większa niż 0 znakó! Pamiętaj, aby twoje hasło było bezpieczne")]
        [StringFieldLengthValidator(MaxLength = 32, ErrorMessage = "hasło nie może być dłuższe niż 32 znaki")]
        public string Password { get; set; }

        [Required(ErrorMessage = "zapomniałeś/aś uzupełnić adres email!")]
        [EmailFieldValidator("wpisałeś/aś niepoprawny adres email! pamiętaj, aby adres zawierał '@'")]
        public string Email { get; set; }

        public string? Bio { get; set; }

        [Required(ErrorMessage = "zapomniałeś/aś wybrać swój kraj")]
        [StringFieldLengthValidator(ErrorMessage = "musisz wybrać kraj, w którym mieszkasz!")]
        public string Country { get; set; }

        [Required(ErrorMessage = "pamiętaj, aby wprowadzić swój wiek")]
        [StringFieldLengthValidator(ErrorMessage = "musisz podać swój wiek")]
        public int Age { get; set; }
        public DateTime creationDate { get; set; }
    }
}
