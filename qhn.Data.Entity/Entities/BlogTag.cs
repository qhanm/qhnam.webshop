using System.ComponentModel.DataAnnotations.Schema;

namespace qhn.Data.Entity.Entities
{
    [Table("BlogTags")]
    public class BlogTag : EntityId<int>
    {
        public BlogTag(int blogId, string tagId)
        {
            BlogId = blogId;
            TagId = tagId;
        }
        public int BlogId { set; get; }

        public string TagId { set; get; }

        [ForeignKey("BlogId")]
        public virtual Blog Blog { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}