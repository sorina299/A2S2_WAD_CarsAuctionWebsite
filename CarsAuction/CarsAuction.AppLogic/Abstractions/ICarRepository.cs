using CarsAuction.AppLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAuction.AppLogic.Abstractions
{
    public interface ICarRepository : IRepository<Car>
    {
    }
}
