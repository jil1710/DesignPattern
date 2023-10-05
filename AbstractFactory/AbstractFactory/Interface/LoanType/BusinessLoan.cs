using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AbstractFactory.Interface.LoanType
{
    public class BusinessLoan : Loan
    {
        public override void GetInterestRate(double r)
        {
            rate = r;
        }

    }
}
