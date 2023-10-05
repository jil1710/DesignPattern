using FactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.PaymentProviders
{
    public class RazorpayPaymentProvider : IPaymentProvider
    {
        public void ProcessPayment(decimal money)
        {
            Console.WriteLine($"Processing Payment of {money} through Razorpay......");
            // Actual Logic or Request to Razorpay to process the payment
        }
    }
}
