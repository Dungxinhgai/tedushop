using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TeduShop.Model.Absttract;

namespace TeduShop.Model.Models
{
    [Table("Products")]
    public class Product : IAuditable, ISeoable, ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(250)]
        public string Alias { get; set; }

        [MaxLength(250)]
        public int CategoryID { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }

        public XElement MoreImages { get; set; }
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        public int? Warranty { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }

        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(50)]
        public string CreateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime? UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(50)]
        public string UpdateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(250)]
        public string MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(250)]
        public string MetDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }
    }
}