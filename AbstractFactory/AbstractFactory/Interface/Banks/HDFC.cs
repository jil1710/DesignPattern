using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interface.Banks
{
    public class HDFC : IBank
    {
        private readonly string bankname;

        public HDFC()
        {
            this.bankname = "HDFC Bank";
        }
        public string GetBankName()
        {
            return bankname;
        }
    }
}
