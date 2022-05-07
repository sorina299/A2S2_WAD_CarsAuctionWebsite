namespace CarsAuction.Models;

public class User : IID
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserTypeID { get; set; }
    public virtual UserType? UserType { get; set; }

    // relation table FavoriteCars
    public IEnumerable<Car>? FavoriteCars { get; set; }
}

