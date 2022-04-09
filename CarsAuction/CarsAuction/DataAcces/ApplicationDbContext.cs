using CarsAuction.Models;
using Microsoft.EntityFrameworkCore;

namespace CarsAuction.DataAcces;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<UserType> UserTypes  { get; set; }
    public DbSet<Auction> Auctions  { get; set; }
    public DbSet<Car> Cars  { get; set; }
    public DbSet<Brand> Brands{ get; set; }
    public DbSet<Model> Models{ get; set; }
}

