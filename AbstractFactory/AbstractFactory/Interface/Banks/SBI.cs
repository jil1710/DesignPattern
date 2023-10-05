using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interface.Banks
{
    public class SBI : IBank
    {
        private readonly string bankname;

        public SBI()
        {
            this.bankname = "SBI Bank";
        }
        public string GetBankName()
        {
            return bankname;
        }
    }
}
