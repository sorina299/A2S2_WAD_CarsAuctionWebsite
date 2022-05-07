namespace CarsAuction.Models;
public class Car : IID
{
    public int ID { get; set; }
    public int Year { get; set; }
    public string? BrandID { get; set; }
    public int? ModelID { get; set; }
    public CarBrand? Brand { get; set; }
    public CarModel? Model { get; set; }

    public IEnumerable<Image>? Images { get; set; }
}