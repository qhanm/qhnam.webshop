using qhn.Data.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace qhnam.Data.Model.ViewModels
{
    public class PageViewModel
    {
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }

        public string Content { set; get; }
        public Status Status { set; get; }
    }
}
