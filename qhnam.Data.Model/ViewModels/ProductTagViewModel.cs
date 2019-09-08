using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace qhnam.Data.Model.ViewModels
{
    public class ProductTagViewModel
    {
        public int ProductId { get; set; }

        [StringLength(50)]
        public string TagId { set; get; }

        public ProductViewModel Product { set; get; }
        public TagViewModel Tag { set; get; }
    }
}
