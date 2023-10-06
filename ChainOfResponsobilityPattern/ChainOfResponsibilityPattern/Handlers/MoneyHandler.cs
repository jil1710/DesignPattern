using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Handlers
{
    public abstract class MoneyHandler
    {
        public MoneyHandler NextHandler;
        public void SetNextHandler(MoneyHandler NextHandler)
        {
            this.NextHandler = NextHandler;
        }
        public abstract void DispatchNote(long requestedAmount);
    }
}
