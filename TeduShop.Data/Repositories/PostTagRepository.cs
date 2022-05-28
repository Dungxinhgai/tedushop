using System;
using System.Linq.Expressions;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IPostTagRepository : IRepository<PostTag>
    {
    
    }

    public class PostTagRepository : RespositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public PostTag GetSingleCondition(Expression<Func<PostTag, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }
    }
}