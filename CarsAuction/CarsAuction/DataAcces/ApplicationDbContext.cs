using CarsAuction.Models;
using Microsoft.EntityFrameworkCore;

namespace CarsAuction.DataAcces;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // User
        modelBuilder.Entity<User>()
            .HasOne(p => p.UserType)
            .WithOne()
            .HasForeignKey<UserType>(p => p.ID); 

        // Car
        modelBuilder.Entity<Car>()
            .HasOne(car => car.Brand)
            .WithOne()
            .HasForeignKey<CarBrand>(brand => brand.ID); 

        modelBuilder.Entity<Car>()
            .HasOne(car => car.Model)
            .WithOne()
            .HasForeignKey<CarModel>(model => model.ID);



    }


    public DbSet<User> Users { get; set; }
    public DbSet<UserType> UserTypes { get; set; }
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<CarBrand> CarBrands { get; set; }
    public DbSet<CarModel> CarModels { get; set; }
    public DbSet<Image> Images { get; set; }
}

