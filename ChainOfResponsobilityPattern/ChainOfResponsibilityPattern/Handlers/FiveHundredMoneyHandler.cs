using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class FiveHundredMoneyHandler : MoneyHandler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 500;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred notes are dispatched by FiveHundredMoneyHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred note is dispatched by FiveHundredMoneyHandler");
                }
            }

            long pendingAmountToBeProcessed = requestedAmount % 500;

            if (pendingAmountToBeProcessed > 0)
            {
                NextHandler.DispatchNote(pendingAmountToBeProcessed);
            }
        }
    }
}
