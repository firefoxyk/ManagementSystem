using ManagementSystem.Domain.Primitives;
using ManagementSystem.Domain.Users;

namespace ManagementSystem.Domain.Announcement
{
    public class Announcement : AggregateRoot
    {
        private Announcement(AnnouncementlId announcementlId, string announcementHeadline, string announcementBody, Guid createdByUserId)
        {
            IdAnnouncement = announcementlId;
            AnnouncementHeadline = announcementHeadline;
            AnnouncementBody = announcementBody;
            CreatedByUserId = createdByUserId;
        }
        private Announcement()
        { }
        public AnnouncementlId IdAnnouncement { get; set; }
        public string AnnouncementHeadline { get; set; }
        public string AnnouncementBody { get; set; }
        public Guid CreatedByUserId { get; set; }
        public User CreatedByUser { get; set; }
    }
}
