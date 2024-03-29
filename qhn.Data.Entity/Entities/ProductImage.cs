﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace qhn.Data.Entity.Entities
{
    [Table("ProductImages")]
    public class ProductImage : EntityId<int>
    {
        public ProductImage(int productId, string path, string caption)
        {
            ProductId = productId;
            Path = path;
            Caption = caption;
        }
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [StringLength(250)]
        public string Path { get; set; }

        [StringLength(250)]
        public string Caption { get; set; }
    }
}