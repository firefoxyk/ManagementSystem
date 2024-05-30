namespace ManagementSystem.Domain.Users
{
    public interface IUserRepository
    {
        Task Add(User user);
        Task Remove(User user);
        Task Edit(User user);
        Task<User> Get(UserId id);
        Task<List<User>> GetAll();
    }
}
