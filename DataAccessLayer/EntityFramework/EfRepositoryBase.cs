using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityLayer.Abstract;
using System.Linq.Expressions;

namespace DataAccessLayer.EntityFramework
{
    public class EfRepositoryBase<T> : IEntityRepository<T> where T : class, IEntity, new()
    {
        public void Add(T entity)
        {
            using (var dbContext = new BlogContext())
            {
                var addedEntity = dbContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                dbContext.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var dbContext = new BlogContext())
            {
                var deletedEntity = dbContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                dbContext.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (var dbContext = new BlogContext())
            {
                var entity = dbContext.Set<T>().FirstOrDefault(filter);
                return entity;
            }
        }

        public List<T> GetList(Expression<Func<T,bool>> filter)
        {
            using (var dbContext = new BlogContext())
            {
                return filter == null ? dbContext.Set<T>().ToList() : dbContext.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
            using (var dbContext = new BlogContext())
            {
                var updatedEntity = dbContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }
    }
}
