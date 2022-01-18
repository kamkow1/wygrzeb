using System;

namespace wygrzebforum.Models
{
    public class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string bio { get; set; }
        public string country { get; set; }
        public int age { get; set; }
        public DateTime creationDate { get; set; }
    }
}
