using qhn.Data.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace qhnam.Data.Model.ViewModels
{
    public class AdvertistmentViewModel
    {
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        [StringLength(250)]
        public string Url { get; set; }

        [StringLength(20)]
        public string PositionId { get; set; }

        public Status Status { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public int SortOrder { set; get; }

        public AdvertistmentPositionViewModel AdvertistmentPosition { get; set; }
    }
}
