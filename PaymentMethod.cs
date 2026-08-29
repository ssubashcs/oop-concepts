namespace ObjectOrientedProgramming
{
    public abstract class PaymentMethod
    {
        public abstract void Pay(decimal amount);
    }

    public sealed class CardPayment : PaymentMethod
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} by card.");
        }
    }

    public sealed class BankTransferPayment : PaymentMethod
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} by bank.");
        }
    }
}
