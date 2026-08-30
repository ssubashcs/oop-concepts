using ObjectOrientedProgramming.Composition;

namespace ObjectOrientedProgramming.Interfaces
{
    public sealed class CheckoutCalculator
    {
        private readonly IDiscountPolicy _discountPolicy; 

        public CheckoutCalculator(IDiscountPolicy discountPolicy)
        {
            ArgumentNullException.ThrowIfNull(discountPolicy);
            
            _discountPolicy = discountPolicy;
        }

        public decimal CalculateFinalTotal(ShoppingCart cart)
        {
            ArgumentNullException.ThrowIfNull(cart);

            decimal finalTotal = cart.Total - _discountPolicy.CalculateDiscount(cart);

            return Math.Max(0m, finalTotal);
        }
    }
}
