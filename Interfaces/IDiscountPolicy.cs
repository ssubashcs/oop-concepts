using ObjectOrientedProgramming.Composition;

namespace ObjectOrientedProgramming.Interfaces
{
    public interface IDiscountPolicy
    {
        decimal CalculateDiscount(ShoppingCart cart);
    }

    public sealed class NoDiscountPolicy : IDiscountPolicy
    {
        public decimal CalculateDiscount(ShoppingCart cart)
        {
            ArgumentNullException.ThrowIfNull(cart);

            return 0m;
        }
    }

    public sealed class PercentageDiscountPolicy : IDiscountPolicy
    {
        private readonly decimal _percentage;

        public PercentageDiscountPolicy(decimal percentage)
        {
            if (percentage < 0m || percentage > 1m)
            {
                throw new ArgumentOutOfRangeException(nameof(percentage), "Invalid percentage.");
            }

            _percentage = percentage;
        }

        public decimal CalculateDiscount(ShoppingCart cart)
        {
            ArgumentNullException.ThrowIfNull(cart);

            return cart.Total * _percentage;
        }
    }
}
