using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : EfRepositoryBase<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using(var dbContext = new BlogContext())
            {
                return dbContext.Blogs.Include(x => x.Category).ToList();
            }
        }
    }
}
