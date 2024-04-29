using Microsoft.EntityFrameworkCore;
using Shoe_Kart_Shopping_DataAccess.Repository.IRepository;
using Shoe_Kart_Shopping_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Shoe_Kart_Shopping_DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            this.dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

      

        public T FirstOrdefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                foreach (var includepProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includepProp);
                }
            }
            return query.FirstOrDefault();
        }



        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        //public T Get(int id)
        //{
        //    return dbSet.Find(id);
        //}

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includeProperties = null)
        {


            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                foreach (var inlcudeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(inlcudeProp);
                }
                

            }
            if (orderby != null)
                return orderby(query).ToList();
            return query.ToList();
        }

        public void Remove(int id)
        {
            T entity = dbSet.Find(id);
            dbSet.Remove(entity);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }

       
    }
}
