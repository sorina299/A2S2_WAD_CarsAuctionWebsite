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

    public bool Add(IEnumerable<M> items) => repository.Add(items);
    public bool Add(M item) => repository.Add(item);

    public bool Update(IEnumerable<M> items) => repository.Update(items);
    public bool Update(M item) => repository.Update(item);

    public bool Delete(IEnumerable<M> items) => repository.Delete(items);
    public bool Delete(M item) => repository.Delete(item);

}
