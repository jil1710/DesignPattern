using StrategyDesignPattern.Enum;

namespace StrategyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select Payment Type : \n1 For CreditCard \n2 For DebitCard \n3 For Cash");
            int SelectedPaymentType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Payment type is : " + SelectedPaymentType);

            Console.WriteLine("\nPlease enter Amount to Pay : ");
            double Amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Amount is : " + Amount);

            PaymentContext context = new PaymentContext();

            if (SelectedPaymentType == (int)PaymentType.CreditCard)
            {
                context.SetPaymentStrategy(new CreditCardPaymentStrategy());
            }
            else if (SelectedPaymentType == (int)PaymentType.DebitCard)
            {
                context.SetPaymentStrategy(new DebitCardPaymentStrategy());
            }
            else if (SelectedPaymentType == (int)PaymentType.Cash)
            {
                context.SetPaymentStrategy(new CashPaymentStrategy());
            }
            else
            {
                Console.WriteLine("You Select an Invalid Option");
            }

            //Finally, call the Pay Method
            context.Pay(Amount);
        }
    }
}