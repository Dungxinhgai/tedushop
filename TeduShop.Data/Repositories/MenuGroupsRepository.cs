using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IMenuGroupsRepository
    {
    }

    public class MenuGroupsRepository : RespositoryBase<MenuGroup>, IMenuGroupsRepository
    {
        public MenuGroupsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}