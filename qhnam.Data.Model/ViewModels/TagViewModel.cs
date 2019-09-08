using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace qhnam.Data.Model.ViewModels
{
    public class TagViewModel
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Type { get; set; }
    }
}
