using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class TwoThousandMoneyHandler : MoneyHandler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 2000;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Two Thousand notes are dispatched by TwoThousandMoneyHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Two Thousand note is dispatched by TwoThousandMoneyHandler");
                }
            }

            long pendingAmountToBeProcessed = requestedAmount % 2000;

            if (pendingAmountToBeProcessed > 0)
            {
                NextHandler.DispatchNote(pendingAmountToBeProcessed);
            }
        }
    }
}
