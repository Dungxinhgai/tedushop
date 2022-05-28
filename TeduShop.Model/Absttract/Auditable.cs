using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Absttract
{
    public abstract class Auditable : IAuditable// lop ao trien khai interface
    {
        public DateTime? CreatedDate { get; set; }

        [MaxLength(256)]
        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength(256)]
        public string UpdateBy { get; set; }
    }
}