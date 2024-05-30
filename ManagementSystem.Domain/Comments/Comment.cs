namespace ManagementSystem.Domain.Comments
{
    using ManagementSystem.Domain.Primitives;
    using ManagementSystem.Domain.Users;
    using ManagementSystem.Domain.Appeal;

    public sealed class Comment : AggregateRoot
    {
        private Comment()
        { }

        public Comment(CommentId id, Guid appealId, Guid userId, string body)
        {
            Id = id;
            AppealId = appealId;
            UserId = userId;
            Body = body;
            Date = DateTime.Now;
        }

        public CommentId Id { get; set; }
        public Guid AppealId { get; set; }
        public Guid UserId { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
    }
}
