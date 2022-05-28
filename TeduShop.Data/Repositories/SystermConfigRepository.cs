using System;
using System.Linq;
using System.Linq.Expressions;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ISystermConfigRepository: IRepository<SystermConfig>
    {
    }

    public class SystermConfigRepository : RespositoryBase<SystermConfig>, ISupportOnlineRepository
    {
        public SystermConfigRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public void Add(SupportOnline entity)
        {
            throw new NotImplementedException();
        }

        public bool CheckContains(Expression<Func<SupportOnline, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<SupportOnline, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Delete(SupportOnline entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteMulti(Expression<Func<SupportOnline, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<SupportOnline> GetMulti(Expression<Func<SupportOnline, bool>> predicate, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<SupportOnline> GetMultiPaging(Expression<Func<SupportOnline, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public SupportOnline GetSingleCondition(Expression<Func<SupportOnline, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public void Update(SupportOnline entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<SupportOnline> IRepository<SupportOnline>.GetAll(string[] includes)
        {
            throw new NotImplementedException();
        }

        SupportOnline IRepository<SupportOnline>.GetSingleById(int id)
        {
            throw new NotImplementedException();
        }
    }
}