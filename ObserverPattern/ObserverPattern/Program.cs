using ObserverPattern.Interface;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject IPhone15 = new Subject("Iphone 15 Pro Max", 190000, "Out Of Stock");

            Observer user1 = new Observer("Abhi");
            user1.AddSubscriber(IPhone15);
            Observer user2 = new Observer("Suhagi");
            user2.AddSubscriber(IPhone15);

            Observer user3 = new Observer("Ria");
            user3.AddSubscriber(IPhone15);

            Console.WriteLine("Iphone 15 Pro Max current state : " + IPhone15.GetAvailability());
            Console.WriteLine();

            user3.RemoveSubscriber(IPhone15);

            // Now the product is available
            IPhone15.SetAvailability("Available");
        }
    }
}