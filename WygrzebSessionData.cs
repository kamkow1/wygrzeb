using System.Threading.Tasks;
using wygrzebforum.Models;

namespace wygrzebforum
{
    public class WygrzebSessionData
    {
        readonly Blazored.SessionStorage.ISessionStorageService sessionStorage;

        public WygrzebSessionData()
        {

        }

        public WygrzebSessionData(Blazored.SessionStorage.ISessionStorageService ss)
        {
            sessionStorage = ss;
        }

        public bool IsUserLoggedIn { get; set; }

        public int CurrentUserId { get; set; }

        public string RemoteIpAdress { get; set; }

        public User User { get; set; }

        public string Dump() => "IsUserLoggedIn=" + this.IsUserLoggedIn + ", " + "CurrentUserId=" + this.CurrentUserId + ", " + "RemoteIpAdress=" + RemoteIpAdress;

    }
}
