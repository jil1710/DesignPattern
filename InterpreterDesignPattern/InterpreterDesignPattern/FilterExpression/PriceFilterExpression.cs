using InterpreterDesignPattern.Interface;
using InterpreterDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.FilterExpression
{
    public class PriceFilterExpression : IProductExpression
    {
        private readonly decimal minPrice;
        private readonly decimal maxPrice;

        public PriceFilterExpression(decimal min, decimal max)
        {
            minPrice = min;
            maxPrice = max;
        }

        public bool Interpret(Product product)
        {
            return product.Price >= minPrice && product.Price <= maxPrice;
        }
    }
}
