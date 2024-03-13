using MongoDB.Entities;

namespace SearchService;

public class Item : Entity
{
    public int ReservePrice { get; set; }
    public string Seller { get; set; }
    public string Winner { get; set; }
    public int SoldAmount { get; set; }
    public int CurrentHighBid { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime AuctionEnd { get; set; }

    public string City { get; set; }
    public string Neighborhood { get; set; }
    public string BuildingType { get; set; }
    public int Rooms { get; set; }
    public int Area { get; set; }
    public int Beds { get; set; }
    public string Floor { get; set; }
    public string ImageUrl { get; set; }
}
