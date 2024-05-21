namespace ManagementSystem.Domain.ValueObjects
{
    using ManagementSystem.Domain.Users;
    using ManagementSystem.Domain.Appeal;
    public partial record AppealComment
    {
        private AppealComment(Guid appealId, Guid userId, DateTime date, string body)
        {
            AppealCommentId = Guid.NewGuid();
            AppealId = appealId;
            UserId = userId;
            Date = date;
            Body = body;
        }
        public Guid AppealCommentId { get; set; }
        public Guid AppealId { get; set; }
        public Appeal Appeal { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public string Body { get; set; }
        public static AppealComment Create(Guid appealId, Guid userId, DateTime date, string body)
        {
            if (appealId == Guid.Empty || userId == Guid.Empty || date == DateTime.MinValue || string.IsNullOrEmpty(body))
            {
                return null;
            }

            return new AppealComment(appealId, userId, date, body);
        }
    }
}
