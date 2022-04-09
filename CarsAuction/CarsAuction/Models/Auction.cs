namespace CarsAuction.Models;
public class Auction
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public User Seller { get; set; }
    public User Buyer { get; set; }
    public Car Car { get; set; }
    public float CurrentBid { get; set; }
    public DateTime StartingDate { get; set; }
    public DateTime EndingDate { get; set; }
}
