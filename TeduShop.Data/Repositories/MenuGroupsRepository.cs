using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;
using System;
using System.Linq.Expressions;


namespace TeduShop.Data.Repositories
{
    public interface IMenuGroupsRepository: IRepository<MenuGroup>
    {
    }

    public class MenuGroupsRepository : RespositoryBase<MenuGroup>, IMenuGroupsRepository
    {
        public MenuGroupsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public MenuGroup GetSingleCondition(Expression<Func<MenuGroup, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }
    }
}