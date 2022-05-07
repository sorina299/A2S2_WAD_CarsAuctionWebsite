namespace CarsAuction.Models;
public class Auction : IID
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public float CurrentBid { get; set; }
    public DateTime StartingDate { get; set; }
    public DateTime EndingDate { get; set; }

    public int SellerID { get; set; }
    public int BuyerID { get; set; }
    public int CarID { get; set; }
    
    public virtual User? Seller { get; set; }
    public virtual User? Buyer { get; set; }
    public virtual Car? Car { get; set; }

}
