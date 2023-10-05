using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.Services
{
    public class Invoice
    {
        public void SendInvoice()
        {
            // Send the invoice or bill of the product to user...
            // Save it to invoice table in database...
            Console.WriteLine("Invoice Send Successfully!");
        }
    }
}
