using CarsAuction.AppLogic.Abstractions;
using CarsAuction.AppLogic.Models;
using CarsAuction.DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAuction.DataAccess.Repositories;

public class Repository<T> : IRepository<T> where T : class, IID
{
    protected readonly ApplicationDbContext dbContext;
    public Repository(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public IEnumerable<T> Get() => dbContext.Set<T>().ToArray();
    public T Get(int id) => dbContext.Set<T>().Where( p => p.ID == id ).FirstOrDefault();
    
    public void Add(T item)
    {
        dbContext.Set<T>().Add(item);
        dbContext.SaveChanges();
    }

    public void Add(IEnumerable<T> items)
    {
        dbContext.Set<T>().AddRange(items);
        dbContext.SaveChanges();
    }

    public void Update(T item)
    {
        dbContext.Set<T>().Update(item);
        dbContext.SaveChanges();
    }

    public void Update(IEnumerable<T> items)
    {
        dbContext.Set<T>().UpdateRange(items);
        dbContext.SaveChanges();
    }

    public void Delete(T item)
    {
        dbContext.Set<T>().Remove(item);
        dbContext.SaveChanges();
    }

    public void Delete(IEnumerable<T> items)
    {
        dbContext.Set<T>().RemoveRange(items);
        dbContext.SaveChanges();
    }

}
