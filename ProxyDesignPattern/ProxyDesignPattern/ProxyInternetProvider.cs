using ProxyDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class ProxyInternetProvider : IInternet
    {
        private IInternet internet = new RealInternetProvider();
        private static List<string> bannedSites = new List<String>();

        static ProxyInternetProvider()
        {
            bannedSites.Add("www.abc.com");
            bannedSites.Add("pqrstuv.com");
            bannedSites.Add("world.com");
            bannedSites.Add("cricket.com");
        }
        public void ConnectToWebHost(string serverhost)
        {
            if (bannedSites.Contains(serverhost.ToLower()))
            {
                throw new Exception($"Access Denied for this web host {serverhost}");
            }

            internet.ConnectToWebHost(serverhost);
        }
    }
}
