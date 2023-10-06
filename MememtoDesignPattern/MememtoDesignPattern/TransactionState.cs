using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MememtoDesignPattern
{
    public class TransactionState
    {
        public decimal Balance { get; }

        public TransactionState(decimal balance)
        {
            this.Balance = balance;
        }
    }
}
