namespace ObjectOrientedProgramming.Inheritance
{
    public abstract class PaymentMethod
    {
        internal string Name { get; }

        protected PaymentMethod(string name)
        {
            Name = name;
        }

        public void Pay(decimal amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero.");

            ProcessPayment(amount);
        }

        protected abstract void ProcessPayment(decimal amount);
    }

    public sealed class CardPayment : PaymentMethod
    {
        public CardPayment() : base("Card Payment")
        {
            
        }

        protected override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Paid {amount} by card.");
        }
    }

    public sealed class BankTransferPayment : PaymentMethod
    {
        public BankTransferPayment() : base("Bank transfer Payment")
        {

        }

        protected override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Paid {amount} by bank.");
        }
    }
}
