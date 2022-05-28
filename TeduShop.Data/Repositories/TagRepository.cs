using System;
using System.Linq.Expressions;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ITagRepository: IRepository<Tag>
    {
    }

    public class TagRepository : RespositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public Tag GetSingleCondition(Expression<Func<Tag, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }
    }
}