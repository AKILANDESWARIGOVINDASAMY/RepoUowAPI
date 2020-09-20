using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoUowAPI.DAL
{
    public class Unitofwork : IUnitofwork
    {
        public IProductRepository _products;
        public IProductRepository Products { get; set; }
        public Dbcontext _context;
        public Unitofwork(Dbcontext dbContext)
        {
            _context = dbContext;
            Products = new ProductRepository(_context);

        }      

        public int complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
     
        /*    private readonly Dbcontext _context;
            public Unitofwork(Dbcontext context)
            {
                _context = context;
                Developers = new ProductRepository(_context);
               
            }
            public IProductRepository Developers { get; private set; }
            public IProductRepository Projects { get; private set; }

       // public IProductRepository Products => throw new NotImplementedException();
        public int complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
            {
                _context.Dispose();
            }
        }*/
    }
