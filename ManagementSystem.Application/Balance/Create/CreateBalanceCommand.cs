namespace ManagementSystem.Application.Balance.Create
{
    using MediatR;
    public record class CreateBalanceCommand(
        string OperationType,
        decimal Amount,
        string OperationDescription
        ): IRequest<Unit>;
}
