using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace qhn.Data.Entity.Entities
{
    [Table("AnnouncementUsers")]
    public class AnnouncementUser : EntityId<int>
    {
        public AnnouncementUser()
        {
        }

        public AnnouncementUser(string announcementId, Guid userId, bool? hasRead)
        {
            AnnouncementId = announcementId;
            UserId = userId;
            HasRead = hasRead;
        }

        [StringLength(128)]
        [Required]
        public string AnnouncementId { get; set; }

        public Guid UserId { get; set; }

        public bool? HasRead { get; set; }

        [ForeignKey("AnnouncementId")]
        public virtual Announcement Announcement { get; set; }
    }
}