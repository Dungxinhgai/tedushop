using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Absttract;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    public class Page : ISeoable, ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(250)]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(250)]
        [Required]
        public string Alias { get; set; }

        public string Content { get; set; }

        [MaxLength(250)]
        public string MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [MaxLength(250)]
        public string MetDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}