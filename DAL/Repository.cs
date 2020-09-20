using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoUowAPI.DAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly Dbcontext _context;

        public Repository(Dbcontext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public T Get(int Id)
        {
            return _context.Set<T>().Find(Id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Remove(int Id)
        {
         T entity = _context.Set<T>().Find(Id);
            _context.Set<T>().Remove(entity);
        }        
    }
}
