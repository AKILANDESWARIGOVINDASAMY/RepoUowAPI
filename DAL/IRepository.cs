using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoUowAPI.DAL
{
    public interface IRepository<T> where T : class
    {

        IEnumerable<T> GetAll();
        T Get(int Id);
        void Add(T entity);
        void Remove(int Id);
    }
}
