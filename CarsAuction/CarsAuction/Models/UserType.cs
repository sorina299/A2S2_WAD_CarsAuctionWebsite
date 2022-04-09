using System.ComponentModel.DataAnnotations;

namespace CarsAuction.Models;

public class UserType
{
    [Key]
    public string Type { get; set; }
}
