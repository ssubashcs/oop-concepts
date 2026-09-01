namespace ObjectOrientedProgramming.SRP
{
    public static class ReceiptFormatter
    {
        public static string Format(CheckoutReceipt receipt)
        {
            ArgumentNullException.ThrowIfNull(receipt);

            return $"""
            ===== CHECKOUT RECEIPT =====

            Subtotal:       {receipt.Subtotal}
            Discount:      -{receipt.Discount}
            ----------------------------
            Total:          {receipt.Total}

            Payment Method: {receipt.PaymentMethodName}
            Address:        {receipt.ShippingAddress}

            ============================
            Thank you for your purchase!
            """;
        }
    }
}
