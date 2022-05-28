using System;
using System.Linq.Expressions;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IOrderRepository: IRepository<Order>
    {
    }

    public class OrderRepository : RespositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public Order GetSingleCondition(Expression<Func<Order, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }
    }
}