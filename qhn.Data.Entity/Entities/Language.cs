using qhn.Data.Entity.Enums;
using qhn.Data.Entity.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace qhn.Data.Entity.Entities
{
    [Table("Languages")]
    public class Language : EntityId<string>, ISwitchable
    {
        public Language(string name, bool isDefault, string resources, Status status)
        {
            Name = name;
            IsDefault = isDefault;
            Resources = resources;
            Status = status;
        }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public string Resources { get; set; }

        public Status Status { get; set; }
    }
}