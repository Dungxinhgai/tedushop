using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Footers")]// tao ra ten bang
    public class Footer
    {
        [Key]// khoa chinh
        [MaxLength(50)]
        public string ID { get; set; }

        [Required]// yeu cau bat buoc ko duoc de trong
        public string Content { get; set; }
    }
}