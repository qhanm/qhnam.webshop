using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace qhn.Data.Entity.Entities
{
    [Table("Sizes")]
    public class Size : EntityId<int>
    {
        public Size(string name)
        {
            Name = name;
        }
        [StringLength(250)]
        public string Name
        {
            get; set;
        }
    }
}