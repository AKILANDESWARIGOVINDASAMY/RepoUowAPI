using Microsoft.EntityFrameworkCore;
using RepoUowAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoUowAPI.DAL
{
    public class Dbcontext: DbContext    {
 

        public Dbcontext(DbContextOptions<Dbcontext> options) : base(options)
            {
            }
            public DbSet<Product> Products { get; set; }
           
        
    }
}
