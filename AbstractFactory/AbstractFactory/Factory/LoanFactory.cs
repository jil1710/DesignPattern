using AbstractFactory.Interface.LoanType;
using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class LoanFactory : Abstract_Factory
    {
        public override IBank GetBank(String bank)
        {
            return null;
        }

        public override Loan GetLoan(String loan)
        {
            if (loan == null)
            {
                return null;
            }
            if (loan.Equals("Home"))
            {
                return new HomeLoan();
            }
            else if (loan.Equals("Business"))
            {
                return new BusinessLoan();
            }
            else if (loan.Equals("Education"))
            {
                return new EducationLoan();
            }
            return null;
        }
    }
}
