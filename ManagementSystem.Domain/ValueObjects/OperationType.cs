namespace ManagementSystem.Domain.ValueObjects
{
    public partial record OperationType
    {
        public enum Value
        {
            Income,
            Expense
        }
        public Value? EnumValue { get; }
        private OperationType(Value enumValue) => EnumValue = enumValue;
        public static OperationType Create(string value)
        {
            if (!Enum.TryParse<Value>(value, true, out var enumValue))//спросить тут
            {
                return null;
            }

            return new OperationType(enumValue);
        }
    }
}
