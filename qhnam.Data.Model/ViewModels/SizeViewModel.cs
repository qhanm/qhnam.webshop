using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace qhnam.Data.Model.ViewModels
{
    public class SizeViewModel
    {
        [StringLength(250)]
        public string Name { get; set;}
    }
}
