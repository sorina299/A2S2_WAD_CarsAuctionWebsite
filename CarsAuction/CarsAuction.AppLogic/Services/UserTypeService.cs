using CarsAuction.AppLogic.Abstractions;
using CarsAuction.AppLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAuction.AppLogic.Services
{
    public class UserTypeService : Service<UserType>
    {
        public UserTypeService(IRepository<UserType> repository) : base(repository)
        {
        }
    }
}
