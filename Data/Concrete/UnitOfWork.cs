using Data.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<City> Cities
        {
            get; private set;
        }

        public IRepository<CarDetail> CarDetails { get; private set; }

        public IRepository<CarType> CarTypes { get; private set; }

        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Cities = new Repository<City>(_db);
            CarTypes = new Repository<CarType>(_db);
            CarDetails = new Repository<CarDetail>(_db);    

        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
