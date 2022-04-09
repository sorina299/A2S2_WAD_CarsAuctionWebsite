﻿namespace CarsAuction.Models;

public class User
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public UserType Type { get; set; }

    // relation table FavoriteCars
    public IEnumerable<Car> FavoriteCars { get; set; }
}

