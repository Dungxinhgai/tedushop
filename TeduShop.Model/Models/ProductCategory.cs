using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Absttract;

namespace TeduShop.Model.Models
{
    [Table("ProductCategorys")]
    public class ProductCategory : IAuditable, ISeoable, ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// tu tang ID giong IDENTITY
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public int? ParentID { get; set; }
        public int? DisplayOrder { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public DateTime? CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(50)]
        public string CreateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime? UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(50)]
        public string UpdateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(250)]
        public string MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(250)]
        public string MetDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}