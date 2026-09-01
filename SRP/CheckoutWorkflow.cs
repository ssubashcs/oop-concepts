using ObjectOrientedProgramming.Composition;
using ObjectOrientedProgramming.Immutability;
using ObjectOrientedProgramming.Inheritance;
using ObjectOrientedProgramming.Interfaces;

namespace ObjectOrientedProgramming.SRP
{
    public sealed class CheckoutWorkflow
    {
        public CheckoutReceipt CheckoutPurchase(ShoppingCart cart, IDiscountPolicy discountPolicy, PaymentMethod payment, ShippingAddress address)
        {
            ArgumentNullException.ThrowIfNull(cart);
            ArgumentNullException.ThrowIfNull(discountPolicy);
            ArgumentNullException.ThrowIfNull(payment);
            ArgumentNullException.ThrowIfNull(address);

            if (cart.Items.Count == 0)
                throw new InvalidOperationException("Cannot checkout an empty cart.");

            decimal discountAmount = CalculateDiscount(cart, discountPolicy);

            decimal finalTotal = CalculateTotal(cart.Total, discountAmount);

            ProcessPayment(payment, finalTotal);

            return GenerateReceipt(cart.Total, discountAmount, finalTotal, payment.Name, address);
        }

        private static decimal CalculateDiscount(ShoppingCart cart, IDiscountPolicy discountPolicy)
        {
            return discountPolicy.CalculateDiscount(cart);
        }

        private static decimal CalculateTotal(decimal subTotal, decimal discountAmount)
        {
            return CheckoutCalculator.CalculateFinalTotal(subTotal, discountAmount);
        }

        private static void ProcessPayment(PaymentMethod paymentMethod, decimal amount)
        {
            CheckoutService.Checkout(paymentMethod, amount);
        }

        private static CheckoutReceipt GenerateReceipt(decimal subTotal, decimal discountAmt, decimal finalAmt, string payment, ShippingAddress address)
        {
            return new(subTotal, discountAmt, finalAmt, payment, address);
        }
    }
}
