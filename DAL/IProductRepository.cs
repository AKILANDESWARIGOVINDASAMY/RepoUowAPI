using RepoUowAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoUowAPI.DAL
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetTopProducts();            
    }
}
