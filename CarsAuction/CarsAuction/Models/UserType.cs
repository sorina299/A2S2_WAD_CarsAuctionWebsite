using System.ComponentModel.DataAnnotations;

namespace CarsAuction.Models;

public class UserType : IID
{
    public int ID { get; set; }
    public string Title { get; set; }
    //public IEnumerable<User> Users { get; set; }
}
