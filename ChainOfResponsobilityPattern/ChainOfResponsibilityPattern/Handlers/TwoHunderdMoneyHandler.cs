using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class TwoHunderdMoneyHandler : MoneyHandler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 200;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Two Hundred notes are dispatched by TwoHunderdMoneyHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Two Hundred note is dispatched by TwoHunderdMoneyHandler");
                }
            }

            long pendingAmountToBeProcessed = requestedAmount % 200;

            if (pendingAmountToBeProcessed > 0)
            {
                NextHandler.DispatchNote(pendingAmountToBeProcessed);
            }
        }
    }
}
