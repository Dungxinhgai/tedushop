using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Absttract
{
    public interface ISeoable
    {
        string MetaKeyword { get; set; }
        string MetDescription { get; set; }
    }
}
