using ManagementSystem.Domain.Users;

namespace ManagementSystem.Domain.Entities.Announcement
{
    public class Announcement
    {
        private Announcement(string announcementHeadline, string announcementBody, Guid createdByUserId)
        {
            IdAnnouncement = Guid.NewGuid();
            AnnouncementHeadline = announcementHeadline;
            AnnouncementBody = announcementBody;
            CreatedByUserId = createdByUserId;
        }
        public Guid IdAnnouncement { get; set; }
        public string AnnouncementHeadline { get; set; }
        public string AnnouncementBody { get; set; }
        public Guid CreatedByUserId { get; set; }
        public User CreatedByUser { get; set; }

        public static Announcement Create(string announcementHeadline, string announcementBody, Guid createdByUserId)
        {
            if (string.IsNullOrEmpty(announcementHeadline) || string.IsNullOrEmpty(announcementBody) || createdByUserId == Guid.Empty)
            {
                return null;
            }
            return new Announcement(announcementHeadline, announcementBody, createdByUserId);
        }
    }
}
