using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Footers")]// tao ra ten bang
    public class Footer
    {
        [Key]// khoa chinh
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }
        [Required]// yeu cau bat buoc ko duoc de trong
        public string Content { get; set; }
    }
}
