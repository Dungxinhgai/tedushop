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
    [Table("Slides")]
    public class Slide: ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }    
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string URL { get; set; }
        public int DisplayOrder { get; set; }
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
