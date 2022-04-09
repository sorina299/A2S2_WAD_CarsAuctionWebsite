using System.ComponentModel.DataAnnotations;

namespace CarsAuction.Models;
public class Model
{
    [Key]
    public Brand Brand { get; set; }
    [Key]
    public string Name { get; set; }
}

