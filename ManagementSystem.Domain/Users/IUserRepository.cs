namespace ManagementSystem.Domain.Users
{
    public interface IUserRepository
    {
        //Task<User?> GetByIdAsync(Id id);
        Task Add(User user);
    }
}
