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

        [Required(ErrorMessage = "zapomniałeś/aś podać hasło!")]
        [StringFieldLengthValidator(MaxLength = 32, ErrorMessage = "hasło nie może być dłuższe niż 32 znaki")]
        public string Password { get; set; }

        [Required(ErrorMessage = "zapomniałeś/aś uzupełnić adres email!")]
        [EmailFieldValidator("wpisałeś/aś niepoprawny adres email! pamiętaj, aby adres zawierał '@'")]
        public string Email { get; set; }

        public DateTime creationDate { get; set; }


        [Range(typeof(bool), "true", "true", ErrorMessage = "aby założyć konto, musisz wyrazić zgodę!")]
        public bool PolicyAgreement { get; set; }
    }
}
