namespace ObjectOrientedProgramming.Interfaces
{
    public static class CheckoutCalculator
    {
        public static decimal CalculateFinalTotal(decimal subTotal, decimal discountAmount)
        {
            decimal finalTotal = subTotal - discountAmount;

            return Math.Max(0m, finalTotal);
        }
    }
}
