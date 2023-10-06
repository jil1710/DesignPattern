namespace MememtoDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000.00M);
            TransactionHistory history = new TransactionHistory();

            account.Deposit(200);
            history.SaveState(account);  // Balance: 1200

            account.Withdraw(100);
            history.SaveState(account);  // Balance: 1100

            account.Withdraw(50);
            history.SaveState(account);  // Balance: 1050

            // Oops! That last withdrawal was a mistake. Let's undo it.
            account.RestoreFromState(history.UndoTransaction());

            Console.WriteLine($"Current Balance: ${account.Balance}");
            // Outputs: Current Balance: $1100.00
        }
    }
}