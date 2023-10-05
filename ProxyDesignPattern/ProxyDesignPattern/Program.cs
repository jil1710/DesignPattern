using ProxyDesignPattern.Interface;

namespace ProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IInternet internet = new ProxyInternetProvider();
            try
            {
                internet.ConnectToWebHost("www.google.com");
                internet.ConnectToWebHost("www.abc.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
    }
}