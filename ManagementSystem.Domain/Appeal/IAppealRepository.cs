namespace ManagementSystem.Domain.Appeal
{
    public interface IAppealRepository//спроси тут
    {
        Task Add(Appeal appeal);
        Task Edit(Appeal appeal);
        Task<Appeal> Get(AppealId id);
        Task<List<Appeal>> GetAll();
    }
}
