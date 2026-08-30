namespace ObjectOrientedProgramming.Immutability
{
    public sealed record ShippingAddress
    {   
        public string Street { get; }
        public string City { get; }
        public string PostalCode { get; }
        public string Country { get; }

        public ShippingAddress(string street, string city, string postalCode, string country)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(street);
            ArgumentException.ThrowIfNullOrWhiteSpace(city);
            ArgumentException.ThrowIfNullOrWhiteSpace(postalCode);
            ArgumentException.ThrowIfNullOrWhiteSpace(country);

            Street = street;
            City = city;
            PostalCode = postalCode;
            Country = country;
        }
    }
}
