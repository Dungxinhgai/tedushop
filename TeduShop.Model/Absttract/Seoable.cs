using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Absttract
{
    public abstract class Seoable : ISeoable
    {
        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetDescription { get; set; }
    }
}