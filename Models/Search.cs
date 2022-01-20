using System;

namespace wygrzebforum.Models
{
    public class Search
    {
        public int id { get; set; }
        public string query { get; set; }
        public DateTime timeStamp { get; set; }
        public int userId { get; set; }
    }
}
