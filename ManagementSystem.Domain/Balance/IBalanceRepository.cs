namespace ManagementSystem.Domain.Balance
{
    public interface IBalanceRepository
    {
        //Task<Balance?> GetByIdAsync(Id id);
        Task Add(Balance balance);
        Task<Balance> Get(BalanceId id);
        Task<List<Balance>> GetAll();
    }
}
