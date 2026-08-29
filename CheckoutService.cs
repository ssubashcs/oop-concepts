namespace ObjectOrientedProgramming
{
    public static class CheckoutService
    {
        public static void Checkout(ShoppingCart cart, PaymentMethod paymentMethod)
        {
            ArgumentNullException.ThrowIfNull(cart);
            ArgumentNullException.ThrowIfNull(paymentMethod);

            if (cart.Items.Count == 0) throw new InvalidOperationException("Cannot checkout an empty cart.");

            paymentMethod.Pay(cart.Total);
        }
    }
}
