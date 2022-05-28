using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IPostCategoryRepository: IRepository<PostCategory>
    {

    }
    public class PostCategoryRepository:RespositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public PostCategory GetSingleCondition(Expression<Func<PostCategory, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }
    }
}
