using System;
using System.ComponentModel.DataAnnotations;
using wygrzebforum.Models.CustomDataValidators;

namespace wygrzebforum.Models
{
    public class Article
    {
        public int id { get; set; }
        public DateTime creationDate { get; set; }

        [StringFieldLengthValidator(MaxLength = 60, ErrorMessage = "długość tytułu nie może przekraczać 60 znaków")]
        [Required(ErrorMessage = "artykuł musi zawierać tytuł")]
        public string title { get; set; }

        [StringFieldLengthValidator(MaxLength = 1000, ErrorMessage = "długość zawartości nie może przekraczać 1000 znaków")]
        [Required(ErrorMessage = "artykuł musi zawierać treść")]
        public string content { get; set; }

        [Required(ErrorMessage = "artykuł musi zawierać miniaturkę")]
        public string thumbail { get; set; }
        public int upvotes { get; set; }
        public int downvotes { get; set; }
        public int viewCount { get; set; }
        public int userId { get; set; }
    }
}
