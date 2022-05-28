using System;
using System.Linq.Expressions;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IVisistorStaticRepository : IRepository<VisistorStatic>
    {
    }

    public class VisistorStaticRepository : RespositoryBase<VisistorStatic>, IVisistorStaticRepository
    {
        public VisistorStaticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public VisistorStatic GetSingleCondition(Expression<Func<VisistorStatic, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }
    }
}