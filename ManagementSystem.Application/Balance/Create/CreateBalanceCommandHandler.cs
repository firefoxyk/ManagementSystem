namespace ManagementSystem.Application.Balance.Create
{
    using ManagementSystem.Domain.Balance;
    using ManagementSystem.Domain.Primitives;
    using ManagementSystem.Domain.ValueObjects;
    using MediatR;
    internal sealed class CreateBalanceCommandHandler : IRequestHandler<CreateBalanceCommand, Unit>
    {
        private readonly IBalanceRepository _balanceRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateBalanceCommandHandler(IUnitOfWork unitOfWork, IBalanceRepository balanceRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _balanceRepository = balanceRepository ?? throw new ArgumentNullException(nameof(balanceRepository)); 
        }
        public async Task<Unit> Handle(CreateBalanceCommand command, CancellationToken cancellationToken)
        {
            try
            {
                if (OperationType.Create(command.OperationType) is not OperationType operationType)
                {
                    throw new ArgumentNullException(nameof(operationType));
                }

                Balance balance = new Balance(new BalanceId(Guid.NewGuid()), operationType, command.Amount, command.OperationDescription);

                await _balanceRepository.Add(balance);
                await _unitOfWork.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
            catch
            {
                throw;
            }
        }
    }
}
