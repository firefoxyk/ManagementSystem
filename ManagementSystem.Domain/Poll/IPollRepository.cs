namespace ManagementSystem.Domain.Poll
{
    public interface IPollRepository
    {
        Task Add(Poll poll);
        Task Remove(Poll poll);
        Task Edit(Poll poll);
        Task<Poll> Get(PollId id);
        Task<List<Poll>> GetAll();
    }
}
