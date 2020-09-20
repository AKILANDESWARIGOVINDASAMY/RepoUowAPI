using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoUowAPI.DAL
{
    public interface IUnitofwork:IDisposable
    {
        IProductRepository Products { get; }
        int complete();

    }
}
