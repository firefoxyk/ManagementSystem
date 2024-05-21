namespace ManagementSystem.Domain.ValueObjects
{
    public partial record Address
    {
        private Address(string region, string city, string district, string street, byte house, ushort apartment, string zipCode)
        {
            Region = region;
            City = city;
            District = district;
            Street = street;
            House = house;
            Apartment = apartment;
            ZipCode = zipCode;
        }
        public string Region { get; init; }
        public string City { get; init; }
        public string District { get; init; }
        public string Street { get; init; }
        public byte House { get; init; }
        public ushort Apartment { get; init; }
        public string ZipCode { get; init; }
        public static Address? Create(string region, string city, string district, string street, byte house, ushort apartment, string zipCode)
        {
            if (string.IsNullOrEmpty(region) ||
                string.IsNullOrEmpty(region) ||
                string.IsNullOrEmpty(region) ||
                string.IsNullOrEmpty(region) ||
                string.IsNullOrEmpty(region) ||
                string.IsNullOrEmpty(region) ||
                string.IsNullOrEmpty(region))
            {
                return null;
            }
            return new Address(region, city, district, street, house, apartment, zipCode);
        }
    }
}
