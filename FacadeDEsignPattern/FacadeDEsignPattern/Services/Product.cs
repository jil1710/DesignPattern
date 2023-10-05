using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.Services
{
    public class Product
    {
        public void GetProductDetails()
        {
            // In real you can fetch the product from DB.
            // Here our motto is to discover Facade Pattern
            Console.WriteLine("Fetching the Product Details...");
        }
    }
}
