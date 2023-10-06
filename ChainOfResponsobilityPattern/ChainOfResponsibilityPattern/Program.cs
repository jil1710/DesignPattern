namespace ChainOfResponsibilityPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATMMachine atm = new ATMMachine();
            Console.WriteLine("Requested Amount 4500");
            atm.Withdraw(4500);

            Console.WriteLine("\nRequested Amount 1000");
            atm.Withdraw(1000);

            Console.WriteLine("\nRequested Amount 1500");
            atm.Withdraw(1500);

            Console.WriteLine("\nRequested Amount 750");
            atm.Withdraw(750);
        }
    }
}