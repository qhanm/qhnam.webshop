using qhn.Data.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace qhnam.Data.Model.ViewModels
{
    public class AnnouncementViewModel
    {
        [Required]
        [StringLength(250)]
        public string Title { set; get; }

        [StringLength(250)]
        public string Content { set; get; }

        public Guid UserId { set; get; }

        public AppUserViewModel AppUser { get; set; }

        public ICollection<AnnouncementUserViewModel> AnnouncementUsers { get; set; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public Status Status { set; get; }
    }
}