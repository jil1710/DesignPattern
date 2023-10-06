using InterpreterDesignPattern.Interface;
using InterpreterDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.FilterExpression
{
    public class BrandFilterExpression : IProductExpression
    {
        private readonly string brand;

        public BrandFilterExpression(string brand)
        {
            this.brand = brand;
        }

        public bool Interpret(Product product)
        {
            return product.Brand == brand;
        }
    }
}
