using System;
using wygrzebforum.Models.CustomDataValidators;

namespace wygrzebforum.Models
{
    public class Search
    {
        public int id { get; set; }

        [StringFieldLengthValidator(MaxLength = 1, ErrorMessage = "zapytanie musi mieć co najmniej 1 znak!")]
        public string query { get; set; }
        public DateTime timeStamp { get; set; }
        public int userId { get; set; }
    }
}
