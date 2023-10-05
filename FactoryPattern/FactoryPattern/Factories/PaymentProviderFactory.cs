using FactoryPattern.Interface;
using FactoryPattern.PaymentProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factories
{
    public class PaymentProviderFactory
    {
        public static IPaymentProvider GetPaymentProvider(string providername)
        {
            switch (providername.ToLower())
            {
                case "paypal":
                    return new PaypalPaymentProvider();
                case "stripe":
                    return new StriptPaymentProvider();
                case "razorpay":
                    return new RazorpayPaymentProvider();
                default:
                    throw new ArgumentException("Invalid payment provider specified");
            }
        }
    }
}
