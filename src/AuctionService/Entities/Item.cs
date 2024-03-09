using System.ComponentModel.DataAnnotations.Schema;
using AuctionService.Entities;

namespace AuctionService;

[Table("Items")]

public class Item
{
    public Guid Id { get; set; }
    public string City { get; set; }
    public string Neighborhood { get; set; }
    public string BuildingType { get; set; }
    public int Rooms { get; set; }
    public int Area { get; set; }
    public int Beds { get; set; }
    public string Floor { get; set; }
    public string ImageUrl { get; set; }

    // nav properties

    public Auction Auction { get; set; }
    public Guid AuctionId { get; set; }

}