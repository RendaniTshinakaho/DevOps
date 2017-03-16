using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryIt.IRepository;

namespace QueryIt.Repository
{
    public class SqlRepository<T> : IRepository<T> where T : class
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
            _set.Add(newEntity);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
