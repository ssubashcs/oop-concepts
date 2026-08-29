namespace ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a bank account and encapsulates account state and behavior.
    /// </summary>
    public sealed class BankAccount
    {
        // Properties
        public decimal Balance { get; private set; }
        public string AccountNumber { get; }

        // Constructor
        public BankAccount(string accountNumber, decimal balance)
        {
            if (balance < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(balance), "Balance cannot be negative!");
            }

            if (string.IsNullOrWhiteSpace(accountNumber))
            {
                throw new ArgumentException("Account number invalid!", nameof(accountNumber));
            }

            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            ValidateAmount(amount);

            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            ValidateAmount(amount);

            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds!");
            }

            Balance -= amount;
        }

        private static void ValidateAmount(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero!");
            }
        }
    }
}
