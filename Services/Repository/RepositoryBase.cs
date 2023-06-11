using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class RepositoryBase<T> where T : class
    {
        CDStoreContext _context;
        DbSet<T> _dbSet;

        public RepositoryBase()
        {
            _context = new CDStoreContext();
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsNoTracking();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public bool Delete(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }

        public void Update(T entity)
        {
            var tracker = _dbSet.Attach(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
