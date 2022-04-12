using System.ComponentModel.DataAnnotations;

namespace CarsAuction.Models;
public class Model
{
    [Key]
    public int ID { get; set; }
    public string Name { get; set; }
    public int BrandID { get; set; }
    public virtual Brand Brand { get; set; }
}

