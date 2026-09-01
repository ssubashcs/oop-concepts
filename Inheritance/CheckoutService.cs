namespace ObjectOrientedProgramming.Inheritance
{
    internal static class CheckoutService
    {
        internal static void Checkout(PaymentMethod paymentMethod, decimal amount)
        {
            ArgumentNullException.ThrowIfNull(paymentMethod);

            // This is boundary protection, not a claim that the current workflow produces negative values.
            if (amount <= 0) throw new InvalidOperationException("Amount cannot be zero.");

            paymentMethod.Pay(amount);
        }
    }
}
