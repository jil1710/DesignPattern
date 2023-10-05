using FactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.PaymentProviders
{
    public class PaypalPaymentProvider : IPaymentProvider
    {
        public void ProcessPayment(decimal money)
        {
            Console.WriteLine($"Processing Payment of {money} through Paypal......");
            // Actual Logic or Request to Paypal account to process the payment
        }
    }
}
