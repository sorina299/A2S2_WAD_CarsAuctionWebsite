using CarsAuction.AppLogic.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAuction.AppLogic.Services;

public class Service<M>
{
    private IRepository<M> repository;
    public Service(IRepository<M> repository)
    {
        this.repository = repository;
    }

    public IEnumerable<M> Get() => repository.Get();
    public M Get(int id) => repository.Get(id);

    public void Add(IEnumerable<M> items) => repository.Add(items);
    public void Add(M item) => repository.Add(item);

    public void Update(IEnumerable<M> items) => repository.Update(items);
    public void Update(M item) => repository.Update(item);

    public void Delete(IEnumerable<M> items) => repository.Delete(items);
    public void Delete(M item) => repository.Delete(item);

}
