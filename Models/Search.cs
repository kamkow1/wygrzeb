using System;

namespace wygrzebapi.Models
{
    public class Search
    {
        public int Id { get; set; }

        public string Query { get; set; }

        public DateTime TimeStamp { get; set; }

        public int UserId { get; set; }
    }
}
