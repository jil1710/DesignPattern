using FactoryPattern.Factories;
using FactoryPattern.Interface;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the payment provider (PayPal, Stripe, Razorpay): ");
            string providerName = Console.ReadLine()!;

            try
            {
                IPaymentProvider paymentGateway = PaymentProviderFactory.GetPaymentProvider(providerName);
                paymentGateway.ProcessPayment(100.00M); 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}