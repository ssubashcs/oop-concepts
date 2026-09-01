using ObjectOrientedProgramming.Immutability;

namespace ObjectOrientedProgramming.SRP
{
    public sealed class CheckoutReceipt
    {
        public decimal Subtotal { get; }

        public decimal Discount { get; }

        public decimal Total { get; }

        public string PaymentMethodName { get; }

        public ShippingAddress ShippingAddress { get; }

        public CheckoutReceipt(decimal subTotal, decimal discount, decimal total, string paymentMethod, ShippingAddress shippingAddress)
        {
            Subtotal = subTotal;
            Discount = discount;
            Total = total;
            PaymentMethodName = paymentMethod;
            ShippingAddress = shippingAddress;
        }
    }
}
