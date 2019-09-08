using System.ComponentModel.DataAnnotations;

namespace qhn.Data.Entity.Entities
{
    public class Tag : EntityId<string>
    {
        public Tag(string name, string type)
        {
            Name = name;
            Type = type;
        }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Type { get; set; }
    }
}