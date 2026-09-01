namespace ObjectOrientedProgramming.Inheritance
{
    public abstract class PaymentMethod
    {
        internal string Name { get; }

        protected PaymentMethod(string name)
        {
            Name = name;
        }

        public abstract void Pay(decimal amount);
    }

    public sealed class CardPayment : PaymentMethod
    {
        public CardPayment() : base("Card Payment")
        {
            
        }

        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} by card.");
        }
    }

    public sealed class BankTransferPayment : PaymentMethod
    {
        public BankTransferPayment() : base("Bank transfer Payment")
        {

        }

        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} by bank.");
        }
    }
}
