using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace qhn.Data.Entity.Entities
{
    [Table("AdvertistmentPositions")]
    public class AdvertistmentPosition : EntityId<string>
    {
        public AdvertistmentPosition(string pageId, string name)
        {
            PageId = pageId;
            Name = name;
        }
        [StringLength(20)]
        public string PageId { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [ForeignKey("PageId")]
        public virtual AdvertistmentPage AdvertistmentPage { get; set; }

        public virtual ICollection<Advertistment> Advertistments { get; set; }
    }
}