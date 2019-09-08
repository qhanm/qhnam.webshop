using qhn.Data.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace qhnam.Data.Model.ViewModels
{
    public class LanguageViewModel
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public string Resources { get; set; }

        public Status Status { get; set; }
    }
}
