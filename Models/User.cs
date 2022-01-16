using System;
using System.Collections.Generic;

namespace wygrzebapi.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public DateTime CreationDate { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }

        public string Bio { get; set; }

        public string RemoteIpAdress { get; set; }
    }
}
