namespace ManagementSystem.Domain.Appeal
{
    using ManagementSystem.Domain.Primitives;
    using ManagementSystem.Domain.Users;

    public sealed class Appeal : AggregateRoot
    {
        public Appeal(AppealId id, Guid userId, string headline, string body)
        {
            Id = id;
            UserId = userId;
            Headline = headline;
            Body = body;
        }
        private Appeal()
        { }
        public AppealId Id { get; set; }
        public Guid UserId { get; set; }
        public string Headline { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
    }
}
