using CarsAuction.AppLogic.Abstractions;
using CarsAuction.DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAuction.DataAccess.Repositories;

public class Repository<T> : IRepository<T> where T : class, new()
{
    protected readonly ApplicationDbContext dbContext;
    public Repository(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public bool Add(T item)
    {
        throw new NotImplementedException();
    }

    public bool Add(IEnumerable<T> items)
    {
        throw new NotImplementedException();
    }

    public bool Delete(T item)
    {
        throw new NotImplementedException();
    }

    public bool Delete(IEnumerable<T> items)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> Get()
    {
        throw new NotImplementedException();
    }

    public T Get(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(T item)
    {
        throw new NotImplementedException();
    }

    public bool Update(IEnumerable<T> items)
    {
        throw new NotImplementedException();
    }
}
