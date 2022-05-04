using CarsAuction.AppLogic.Abstractions;
using CarsAuction.AppLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAuction.AppLogic.Services;

public class Service<T> where T : class, IID
{
    private IRepository<T> repository;
    public Service(IRepository<T> repository)
    {
        this.repository = repository;
    }

    public IEnumerable<T> Get() => repository.Get();
    public T Get(int id) => repository.Get(id);

    public void Add(IEnumerable<T> items) => repository.Add(items);
    public void Add(T item) => repository.Add(item);

    public void Update(IEnumerable<T> items) => repository.Update(items);
    public void Update(T item) => repository.Update(item);

    public void Delete(IEnumerable<T> items) => repository.Delete(items);
    public void Delete(T item) => repository.Delete(item);

}
