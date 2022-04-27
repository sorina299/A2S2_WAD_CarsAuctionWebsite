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

    bool Add(M item);
    bool Add(IEnumerable<M> items);

    bool Update(M item);
    bool Update(IEnumerable<M> items);

    bool Delete(M item);
    bool Delete(IEnumerable<M> items);
}
