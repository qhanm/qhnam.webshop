using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace qhnam.Data.Model.ViewModels
{
    public class AnnouncementUserViewModel
    {
        [StringLength(128)]
        [Required]
        public string AnnouncementId { get; set; }

        public Guid UserId { get; set; }

        public bool? HasRead { get; set; }
        public AnnouncementViewModel Announcement { get; set; }
    }
}
