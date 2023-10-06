using ChainOfResponsibilityPattern.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class ATMMachine
    {
        private TwoThousandMoneyHandler twoThousandHandler = new TwoThousandMoneyHandler();
        private FiveHundredMoneyHandler fiveHundredHandler = new FiveHundredMoneyHandler();
        private TwoHunderdMoneyHandler twoHundredHandler = new TwoHunderdMoneyHandler();
        private OneHunderdMoneyHandler onehundredHandler = new OneHunderdMoneyHandler();

        public ATMMachine()
        {
            twoThousandHandler.SetNextHandler(fiveHundredHandler);
            fiveHundredHandler.SetNextHandler(twoHundredHandler);
            twoHundredHandler.SetNextHandler(onehundredHandler);
        }

        public void Withdraw(long requestedAmount)
        {
            if (requestedAmount % 100 == 0)
            {
                twoThousandHandler.DispatchNote(requestedAmount);
            }
            else
            {
                Console.WriteLine($"You Enter Invalid Amount: {requestedAmount}");
            }
        }
    }
}
