using System;

namespace wygrzebforum.Models
{
    public class Article
    {
        public int id { get; set; }
        public DateTime creationDate { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string thumbail { get; set; }
        public int upvotes { get; set; }
        public int downvotes { get; set; }
        public int viewCount { get; set; }
        public int userId { get; set; }
    }
}
