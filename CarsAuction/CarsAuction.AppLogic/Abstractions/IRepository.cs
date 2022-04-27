using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAuction.AppLogic.Abstractions;

public interface IRepository<M>
{
    IEnumerable<M> Get();
    M Get(int id);

    void Add(M item);
    void Add(IEnumerable<M> items);

    void Update(M item);
    void Update(IEnumerable<M> items);

    void Delete(M item);
    void Delete(IEnumerable<M> items);
}
