using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MememtoDesignPattern
{
    public class TransactionHistory
    {
        private Stack<TransactionState> _history = new Stack<TransactionState>();

        public void SaveState(BankAccount account)
        {
            _history.Push(account.CreateState());
        }

        public TransactionState UndoTransaction()
        {
            _history.Pop();
            return _history.First();
        }
    }
}
