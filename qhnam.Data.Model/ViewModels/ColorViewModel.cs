using System.ComponentModel.DataAnnotations;

namespace qhnam.Data.Model.ViewModels
{
    public class ColorViewModel
    {
        [StringLength(250)]
        public string Name
        {
            get; set;
        }

        [StringLength(250)]
        public string Code { get; set; }
    }
}