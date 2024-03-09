namespace AuctionService.DTOs;

public class UpdateAuctionDto
{
    public string City { get; set; }
    public string Neighborhood { get; set; }
    public string BuildingType { get; set; }
    public int? Rooms { get; set; }
    public int? Area { get; set; }
    public int? Beds { get; set; }
    public string Floor { get; set; }
}
