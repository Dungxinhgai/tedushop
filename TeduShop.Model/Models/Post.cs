using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Absttract;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post:IAuditable, ISeoable, ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }
        public int? CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }

        public DateTime? CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CreateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UpdateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MetDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool HomeFlag { get; set; }
        public bool HostFlag { get; set; }
        public int ViewCount { get; set; }

    }
}
