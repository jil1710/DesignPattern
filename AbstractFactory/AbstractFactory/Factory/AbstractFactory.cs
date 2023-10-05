using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public abstract class Abstract_Factory
    {
        public abstract IBank GetBank(String bank);
        public abstract Loan GetLoan(String loan);
    }
}
