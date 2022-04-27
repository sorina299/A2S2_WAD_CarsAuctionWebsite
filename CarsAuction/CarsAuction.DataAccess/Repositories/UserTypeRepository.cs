using CarsAuction.AppLogic.Models;
using CarsAuction.AppLogic.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsAuction.DataAcces;

namespace CarsAuction.DataAccess.Repositories;

public class UserTypeRepository : Repository<UserType>, IUserTypeRepository
{
    public UserTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
