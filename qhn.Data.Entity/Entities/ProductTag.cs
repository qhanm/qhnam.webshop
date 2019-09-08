using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace qhn.Data.Entity.Entities
{
    public class ProductTag : EntityId<int>
    {
        public ProductTag(int productId, string tagId)
        {
            ProductId = productId;
            TagId = tagId;
        }
        public int ProductId { get; set; }

        [StringLength(50)]
        public string TagId { set; get; }

        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}