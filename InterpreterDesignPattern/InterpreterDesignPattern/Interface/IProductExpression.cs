using InterpreterDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern.Interface
{
    public interface IProductExpression
    {
        bool Interpret(Product product);
    }
}
