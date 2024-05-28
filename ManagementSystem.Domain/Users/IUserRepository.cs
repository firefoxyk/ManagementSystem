namespace ManagementSystem.Domain.Users
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(UserId id);
        Task Add(User user);
    }
}
