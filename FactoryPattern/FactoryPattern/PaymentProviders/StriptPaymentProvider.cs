using FactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.PaymentProviders
{
    public class StriptPaymentProvider : IPaymentProvider
    {
        public void ProcessPayment(decimal money)
        {
            Console.WriteLine($"Processing Payment of {money} through Strip......");
            // Actual Logic or Request to Stript to process the payment
        }
    }
}
