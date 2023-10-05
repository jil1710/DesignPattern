using ProxyDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class RealInternetProvider : IInternet
    {
        public void ConnectToWebHost(string serverhost)
        {
            Console.WriteLine($"Connection to Web Server of {serverhost}");
        }
    }
}
