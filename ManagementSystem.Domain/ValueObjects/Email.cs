namespace ManagementSystem.Domain.ValueObjects
{
    using System.Text.RegularExpressions;

    public partial record Email
    {
        private string? Value { get; init; }
        private const string Pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
        private Email(string value) => Value = value;
        public static Email? Create(string value)
        {
            if (string.IsNullOrEmpty(value) || !EmailRegex().IsMatch(value))
            {
                return null;
            }

            return new Email(value);//если все ок, то создаем объект
        }

        [GeneratedRegex(Pattern)]
        private static partial Regex EmailRegex();
    }
}
