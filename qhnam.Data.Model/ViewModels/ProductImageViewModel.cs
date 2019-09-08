using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace qhnam.Data.Model.ViewModels
{
    public class ProductImageViewModel
    {
        public int ProductId { get; set; }

        public ProductViewModel Product { get; set; }

        [StringLength(250)]
        public string Path { get; set; }

        [StringLength(250)]
        public string Caption { get; set; }
    }
}
