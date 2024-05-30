using ManagementSystem.Domain.Primitives;
using ManagementSystem.Domain.Users;

namespace ManagementSystem.Domain.Announcement
{
    public class Announcement : AggregateRoot
    {
        private Announcement(AnnouncementId id,string headline, string body, Guid createdByUserId)
        {
            Id = id;
            Headline = headline;
            Body = body;
            CreatedByUserId = createdByUserId;
        }
        public AnnouncementId Id { get; set; }
        public string Headline { get; set; }
        public string Body { get; set; }
        public Guid CreatedByUserId { get; set; }
    }
}
