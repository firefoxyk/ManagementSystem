namespace ManagementSystem.Domain.Comments
{
    public interface ICommentRepository
    {
        Task Add(Comment comment);
        Task Remove(Comment comment);
        Task Edit(Comment comment);
        Task<Comment> Get(CommentId id);
        Task<List<Comment>> GetAll();
    }
}
