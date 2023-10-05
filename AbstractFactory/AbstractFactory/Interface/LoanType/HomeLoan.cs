using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AbstractFactory.Interface.LoanType
{
    public class HomeLoan : Loan
    {

        public override void GetInterestRate(double rate)
        {
            this.rate = rate;
        }
    }
}
