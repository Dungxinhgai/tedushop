using System;
using System.Linq.Expressions;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IProductRespository : IRepository<Product>
    {
    }

    public class ProductRespository : RespositoryBase<Product>, IProductRespository
    {
        public ProductRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public Product GetSingleCondition(Expression<Func<Product, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }
    }
}