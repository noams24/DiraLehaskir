using System.ComponentModel.DataAnnotations;

namespace AuctionService.DTOs;

public class CreateAuctionDto
{
    [Required]
    public string City { get; set; }
    [Required]
    public string Neighborhood { get; set; }
    [Required]
    public string BuildingType { get; set; }
    [Required]
    public int Rooms { get; set; }
    [Required]
    public int Area { get; set; }
    [Required]
    public int Beds { get; set; }
    [Required]
    public string Floor { get; set; }
    [Required]
    public string ImageUrl { get; set; }
    [Required]
    public int ReservePrice { get; set; }
    [Required]
    public DateTime AuctionEnd { get; set; }
}
