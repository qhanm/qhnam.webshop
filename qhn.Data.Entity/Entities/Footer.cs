using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace qhn.Data.Entity.Entities
{
    [Table("Footers")]
    public class Footer : EntityId<string>
    {
        public Footer(string content)
        {
            Content = content;
        }
        [Required]
        public string Content { set; get; }
    }
}