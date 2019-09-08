using qhn.Data.Entity.Enums;
using qhn.Data.Entity.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace qhn.Data.Entity.Entities
{
    [Table("Pages")]
    public class Page : EntityId<string>, ISwitchable
    {
        public Page()
        {
        }

        public Page(string name, string alias, string content, Status status)
        {
            Name = name;
            Alias = alias;
            Content = content;
            Status = status;
        }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }

        public string Content { set; get; }
        public Status Status { set; get; }
    }
}