using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Absttract;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post : IAuditable, ISeoable, ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(250)]
        [Required]
        public string Alias { get; set; }

        public int? CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public string Content { get; set; }

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

        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool HomeFlag { get; set; }
        public bool HostFlag { get; set; }
        public int ViewCount { get; set; }
    }
}