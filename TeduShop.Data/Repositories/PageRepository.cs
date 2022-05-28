using System;
using System.Linq.Expressions;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IPageRepository: IRepository<Page>
    {
    }

    public class PageRepository : RespositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public Page GetSingleCondition(Expression<Func<Page, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }
    }
}