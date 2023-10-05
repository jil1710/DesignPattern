using AbstractFactory.Interface.Banks;
using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class BankFactory : Abstract_Factory
    {
        public override IBank GetBank(String bank)
        {
            if (bank == null)
            {
                return null;
            }
            if (bank.Equals("HDFC"))
            {
                return new HDFC();
            }
            else if (bank.Equals("ICICI"))
            {
                return new ICICI();
            }
            else if (bank.Equals("SBI"))
            {
                return new SBI();
            }
            return null;
        }
        public override Loan GetLoan(String loan)
        {
            return null;
        }
    }
}
