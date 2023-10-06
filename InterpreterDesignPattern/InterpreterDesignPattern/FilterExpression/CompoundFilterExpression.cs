using InterpreterDesignPattern.Interface;
using InterpreterDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.FilterExpression
{
    public class CompoundFilterExpression : IProductExpression
    {
        private readonly List<IProductExpression> expressions;

        public CompoundFilterExpression(params IProductExpression[] expressions)
        {
            this.expressions = new List<IProductExpression>(expressions);
        }

        public bool Interpret(Product product)
        {
            return expressions.All(expr => expr.Interpret(product));
        }
    }
}
