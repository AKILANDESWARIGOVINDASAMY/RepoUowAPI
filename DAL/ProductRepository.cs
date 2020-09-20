using Microsoft.AspNetCore.Mvc;
using RepoUowAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoUowAPI.DAL
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(Dbcontext context) : base(context)
        {
        }
        public IEnumerable<Product> GetTopProducts([FromQuery]int Count)
        {
            return _context.Products.OrderByDescending(d => d.Productid).Take(Count).ToList();
        }


    }
}
