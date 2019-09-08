using qhn.Data.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace qhnam.Data.Model.ViewModels
{
    public class SystemConfigViewModel
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public string Value1 { get; set; }
        public int? Value2 { get; set; }

        public bool? Value3 { get; set; }

        public DateTime? Value4 { get; set; }

        public Status Status { get; set; }
    }
}
