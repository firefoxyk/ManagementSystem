namespace ManagementSystem.Domain.Balance
{
    using ManagementSystem.Domain.Primitives;
    using ManagementSystem.Domain.ValueObjects;

    public sealed class Balance : AggregateRoot
    {
        public Balance(BalanceId id, OperationType operationType, decimal amount, string operationDescription) 
        {
            BalanceId = id;
            OperationType = operationType;
            Amount = amount;
            OperationDescription = operationDescription;
        }
        private Balance()
        { }

        public BalanceId BalanceId { get; private set; }
        public OperationType OperationType { get; private set; }
        public decimal Amount { get; private set; }
        public string OperationDescription { get; private set; }
    }
}
