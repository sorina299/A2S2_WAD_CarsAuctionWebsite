using System.ComponentModel.DataAnnotations;

namespace CarsAuction.AppLogic.Models;

public class UserType
{
    [Key]
    public string Title { get; set; }
    //public IEnumerable<User> Users { get; set; }
}
