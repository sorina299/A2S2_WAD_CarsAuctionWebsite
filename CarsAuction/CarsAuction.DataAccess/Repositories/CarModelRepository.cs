using CarsAuction.AppLogic.Abstractions;
using CarsAuction.AppLogic.Models;
using CarsAuction.DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAuction.DataAccess.Repositories;

public class CarModelRepository : Repository<CarModel>, ICarModelRepository
{
    public CarModelRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public new CarModel Get( int id )
    {
        return dbContext.CarModels.Where( i => i.ID == id ).FirstOrDefault();
    }
}
