namespace ManagementSystem.Domain.ValueObjects
{
    using System.Text.RegularExpressions;
    public partial record PhoneNumber
    {
        private string? Value { get; init; }
        private const int DefaultLength = 10;
        private const string Pattern = @"^((\+7|\+8|7|8)*(9)+([0-9]){9})$";

        private PhoneNumber(string value) => Value = value;

        public static PhoneNumber? Create(string value)
        {
            if (string.IsNullOrEmpty(value) || !PhoneNumberRegex().IsMatch(value) || value.Length != DefaultLength)
            {
                return null;
            }

            return new PhoneNumber(value);
        }

        [GeneratedRegex(Pattern)]
        private static partial Regex PhoneNumberRegex();
    }
}
