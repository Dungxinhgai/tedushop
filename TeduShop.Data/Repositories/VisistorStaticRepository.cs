using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IVisistorStaticRepository
    {
    }

    public class VisistorStaticRepository : RespositoryBase<VisistorStatic>, IVisistorStaticRepository
    {
        public VisistorStaticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}