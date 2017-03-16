using System;
using System.Data.Entity;
using System.Linq;
using QueryIt.Interfaces;
using QueryIt.IRepository;

namespace QueryIt.Repository
{
    public class SqlRepository<T> : IRepository<T> where T : class,IEntity,new()
    {
        private DbContext _context;
        private DbSet<T> _set;
        public SqlRepository(DbContext context)
        {
            _context = context;
            _set = _context.Set<T>();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Add(T newEntity)
        {
            if (newEntity.IsValid())
            {
                _set.Add(newEntity); 
            }
        }

        public void Delete(T entity)
        {
            _set.Remove(entity);
        }

        public T FindById(int id)
        {
          return  _set.Find(id);
        }

        public IQueryable<T> FindAll()
        {
            return _set;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
