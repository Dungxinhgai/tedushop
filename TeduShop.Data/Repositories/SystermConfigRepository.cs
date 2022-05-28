using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ISystermConfigRepository
    {
    }

    public class SystermConfigRepository : RespositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SystermConfigRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}