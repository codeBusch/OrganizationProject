using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<City> Cities { get; }
        IRepository<CarDetail> CarDetails { get; }
        IRepository<CarType> CarTypes { get; }  
        void Save();

    }
}
