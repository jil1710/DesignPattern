using AbstractFactory.Factory;
using AbstractFactory.Interface;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of Bank from where you want to take loan amount: Type from this [ HDFC, SBI, ICICI ] ");
            string br = Console.ReadLine()!;

            Console.WriteLine("\n");
            Console.WriteLine("Enter the type of loan e.g. Home loan or Business loan or Education loan : ");

            string loanName = Console.ReadLine()!;
            Abstract_Factory bankFactory = FactoryCreator.GetFactory("Bank");
            IBank b = bankFactory.GetBank(br);

            Console.WriteLine("\n");
            Console.WriteLine("Enter the interest rate for " + b.GetBankName() + ": ");

            double rate = Double.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");
            Console.WriteLine("Enter the loan amount you want to take: ");

            double loanAmount = Double.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");
            Console.WriteLine("Enter the number of years to pay your entire loan amount: ");
            int years = int.Parse(Console.ReadLine()!);

            Console.WriteLine("\n");
            Console.WriteLine("you are taking the loan from " + b.GetBankName());

            Abstract_Factory loanFactory = FactoryCreator.GetFactory("Loan");
            Loan l = loanFactory.GetLoan(loanName);
            l.GetInterestRate(rate);
            l.CalculateLoanPayment(loanAmount, years);

            Console.ReadKey();
        }
    }
}