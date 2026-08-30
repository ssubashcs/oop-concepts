namespace ObjectOrientedProgramming.Composition
{
    public class ShoppingCart
    {
        private readonly List<CartItem> _cartItems = new();

        public IReadOnlyList<CartItem> Items => _cartItems.AsReadOnly();
        public decimal Total => _cartItems.Sum(item => item.LineTotal);

        public void AddItem(CartItem cartItem)
        {
            ArgumentNullException.ThrowIfNull(cartItem, nameof(cartItem));

            _cartItems.Add(cartItem);
        }

        public void RemoveItem(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                throw new ArgumentException("Product name is required.", nameof(productName));
            }

            CartItem? item = _cartItems.FirstOrDefault(
                                x => x.ProductName.Equals(
                                    productName, StringComparison.OrdinalIgnoreCase));

            if (item is null)
            {
                throw new InvalidOperationException("Item was not found.");
            }

            _cartItems.Remove(item);
        }
    }
}
