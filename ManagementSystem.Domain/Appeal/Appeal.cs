namespace ManagementSystem.Domain.Appeal
{
    using ManagementSystem.Domain.Primitives;
    using ManagementSystem.Domain.Users;
    using ManagementSystem.Domain.ValueObjects;

    public sealed class Appeal : AggregateRoot
    {
        public Appeal(AppealId appealId, Guid userId, string headline, string body, ICollection<AppealComment> comments) 
        {
            AppealId = appealId;
            UserId = userId;
            Headline = headline;
            Body = body;
            Comments = comments;
        }
        private Appeal()
        { }
        public AppealId AppealId { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Headline { get; set; }
        public string Body { get; set; }
        public ICollection<AppealComment> Comments { get; set; } = new List<AppealComment>();
    }
}
