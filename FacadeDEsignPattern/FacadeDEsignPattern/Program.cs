using FacadeDesignPattern.ClientService;

namespace FacadeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The Client will use the Facade Interface(Order) instead of the Subsystems( Payment, Product, Invoice etc...)
            Order order = new Order();
            order.PlaceOrder();
        }
    }
}