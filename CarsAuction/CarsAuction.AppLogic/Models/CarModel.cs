using System.ComponentModel.DataAnnotations;

namespace CarsAuction.AppLogic.Models;
public class CarModel : IID
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int BrandID { get; set; }
    public virtual CarBrand? Brand { get; set; }
}

