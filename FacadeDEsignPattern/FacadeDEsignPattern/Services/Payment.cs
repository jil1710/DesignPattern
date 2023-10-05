using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.Services
{
    public class Payment
    {
        public void MakePayment()
        {
            // Request to external  payment provider like strip, paypal etc for payment..
            Console.WriteLine("Payment Done Successfully!");
        }
    }
}
