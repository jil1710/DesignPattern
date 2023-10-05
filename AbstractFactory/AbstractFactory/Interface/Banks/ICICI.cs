using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interface.Banks
{
    public class ICICI :IBank
    {
        private readonly string bankname;

        public ICICI()
        {
            this.bankname = "ICICI Bank";
        }
        public string GetBankName()
        {
            return bankname;
        }
    }
}
