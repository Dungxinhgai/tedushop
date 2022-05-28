﻿using System;
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
        IEnumerable<Post> GetAllByTag(string Tag, int pageIndex,int pageSize, out int totalRow);
    }
    public class PostRepository : RespositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetAllByTag(string Tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID==Tag&&p.Status
                        orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count();
            query=query.Skip((pageIndex-1)*pageSize).Take(pageSize);
            return query;
        }

        public Post GetSingleCondition(Expression<Func<Post, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }
    }
     
}
