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
    public interface IPostRepository: IRepository<Post>
    {

    }
    public class PostRepository:RespositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public Post GetSingleCondition(Expression<Func<Post, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }
    }
}
