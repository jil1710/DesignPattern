using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MememtoDesignPattern
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public TransactionState CreateState()
        {
            return new TransactionState(Balance);
        }

        public void RestoreFromState(TransactionState state)
        {
            this.Balance = state.Balance;
        }
    }
}
