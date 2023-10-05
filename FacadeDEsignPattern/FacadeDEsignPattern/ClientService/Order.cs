using FacadeDesignPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.ClientService
{
    public class Order
    {

        // End User only use Order Service and PlaceOrder. They did not care about fetching product detail, payment request, Invoice sending etc will take by Order service palce order..
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started...");

            Thread.Sleep(1000);
            //Get the Product Details
            Product product = new Product();
            product.GetProductDetails();

            Thread.Sleep(2000);
            //Make the Payment
            Payment payment = new Payment();
            payment.MakePayment();

            Thread.Sleep(2000);
            //Send the Invoice
            Invoice invoice = new Invoice();
            invoice.SendInvoice();


            Thread.Sleep(1000);
            Console.WriteLine("Order Placed Successfully..............");
        }
    }
}
