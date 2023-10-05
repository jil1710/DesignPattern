using AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public static class FactoryCreator
    {
        public static Abstract_Factory GetFactory(string choice)
        {
            if (choice.Equals("Bank"))
            {
                return new BankFactory();
            }
            else if (choice.Equals("Loan"))
            {
                return new LoanFactory();
            }
            return null;
        }
    }
}
