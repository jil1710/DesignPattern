using InterpreterDesignPattern.Interface;
using InterpreterDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.FilterExpression
{
    public class ColorFilterExpression : IProductExpression
    {
        private readonly string color;

        public ColorFilterExpression(string color)
        {
            this.color = color;
        }

        public bool Interpret(Product product)
        {
            return product.Color == color;
        }
    }
}
