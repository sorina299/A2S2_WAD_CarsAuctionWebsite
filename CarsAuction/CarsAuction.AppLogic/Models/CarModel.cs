using System.ComponentModel.DataAnnotations;

namespace CarsAuction.Models;
public class CarModel
{
    [Key]
    public int ID { get; set; }
    public string Name { get; set; }
    public int BrandID { get; set; }
    public virtual CarBrand? Brand { get; set; }
}

