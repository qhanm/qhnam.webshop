using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace qhn.Data.Entity.Entities
{
    [Table("Colors")]
    public class Color : EntityId<int>
    {
        public Color(string name, string code)
        {
            Name = name;
            Code = code;
        }

        [StringLength(250)]
        public string Name
        {
            get; set;
        }

        [StringLength(250)]
        public string Code { get; set; }
    }
}