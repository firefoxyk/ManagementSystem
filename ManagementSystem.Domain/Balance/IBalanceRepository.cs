namespace ManagementSystem.Domain.Balance
{
    public interface IBalanceRepository
    {
        Task<Balance?> GetByIdAsync(BalanceId id);
        Task Add(Balance balance);
    }
}
