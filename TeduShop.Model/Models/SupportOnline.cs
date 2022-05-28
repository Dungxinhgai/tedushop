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
    [Table("SupportOnlines")]
    public class SupportOnline: ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Department { get; set; }
        public string Skype { get; set; } 
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Yahoo { get; set; }
        public string FasceBook { get; set; }
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
