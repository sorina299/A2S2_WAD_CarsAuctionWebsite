using CarsAuction.AppLogic.Abstractions;
using CarsAuction.AppLogic.Models;
using CarsAuction.DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAuction.DataAccess.Repositories;

public class AuctionRepository : Repository<Auction>, IAuctionRepository
{
    public AuctionRepository( ApplicationDbContext dbContext ) : base(dbContext)
    {

    }
}
