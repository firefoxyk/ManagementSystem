namespace ManagementSystem.Domain.Appeal
{
    using ManagementSystem.Domain.Comments;
    using ManagementSystem.Domain.Primitives;
    using ManagementSystem.Domain.Users;

    public sealed class Appeal : AggregateRoot
    {
        public Appeal(AppealId id, Guid userId, string headline, string body)
        {
            AppealId = id;
            UserId = userId;
            Headline = headline;
            Body = body;
            Comments = new List<Comment>();//спроси тут
        }
        private Appeal()
        { }
        public AppealId AppealId { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Headline { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();//спроси тут

        public void AddComment(Comment comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }

            Comments.Add(comment);
        }
    }
}
