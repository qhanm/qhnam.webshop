using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace qhn.Data.Entity.Entities
{
    [Table("AdvertistmentPages")]
    public class AdvertistmentPage : EntityId<string>
    {
        public AdvertistmentPage(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public virtual ICollection<AdvertistmentPosition> AdvertistmentPositions { get; set; }
    }
}