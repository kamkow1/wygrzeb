using wygrzebforum.Models;

namespace wygrzebforum
{
    public class Session
    {
        public bool IsUserLoggedIn { get; set; }

        public int CurrentUserId { get; set; }

        public string RemoteIpAdress { get; set; }

        public User User { get; set; }
    }
}
