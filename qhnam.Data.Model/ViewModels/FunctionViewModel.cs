using qhn.Data.Entity.Enums;
using System.ComponentModel.DataAnnotations;

namespace qhnam.Data.Model.ViewModels
{
    public class FunctionViewModel
    {
        [Required]
        [StringLength(128)]
        public string Name { set; get; }

        [Required]
        [StringLength(250)]
        public string URL { set; get; }

        [StringLength(128)]
        public string ParentId { set; get; }

        public string IconCss { get; set; }
        public int SortOrder { set; get; }
        public Status Status { set; get; }
    }
}