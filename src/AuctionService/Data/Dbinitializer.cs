using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

public class DbInitializer
{
    public static void InitDb(WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        SeedData(scope.ServiceProvider.GetService<AuctionDbContext>());
    }

    private static void SeedData(AuctionDbContext context)
    {
        context.Database.Migrate();

        if (context.Auctions.Any())
        {
            Console.WriteLine("Already have data - no need to seed");
            return;
        }

        var auctions = new List<Auction>()
        {
            // 1 tel aviv
            new Auction
            {
                Id = Guid.Parse("afbee524-5972-4075-8800-7d1f9d7b0a0c"),
                Status = Status.Live,
                ReservePrice = 400,
                Seller = "נועם",
                AuctionEnd = DateTime.UtcNow.AddDays(10),
                Item = new Item
                {
                    City = "תל אביב",
                    Neighborhood = "רמת אביב",
                    BuildingType = "וילה",
                    Rooms = 4,
                    Area = 100,
                    Beds = 4,
                    Floor = "ground",
                    ImageUrl = "https://img.yad2.co.il/Pic/202403/02/2_1/o/y2_1pa_010005_20240302183424.jpeg?w=640&h=640&c=9"
                }
            },
            // 2 Haifa
            new Auction
            {
                Id = Guid.Parse("c8c3ec17-01bf-49db-82aa-1ef80b833a9f"),
                Status = Status.Live,
                ReservePrice = 1000000,
                Seller = "נדב",
                AuctionEnd = DateTime.UtcNow.AddDays(60),
                Item = new Item
                       {
                    City = "Haifa",
                    Neighborhood = "Hadar",
                    BuildingType = "appartment",
                    Rooms = 2,
                    Area = 50,
                    Beds = 2,
                    Floor = "2",
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/06/22/11/54/town-2430571_1280.jpg"
                }
            },
            // Netanya
            new Auction
            {
                Id = Guid.Parse("bbab4d5a-8565-48b1-9450-5ac2a5c4a654"),
                Status = Status.Live,
                Seller = "שרון",
                AuctionEnd = DateTime.UtcNow.AddDays(4),
                Item = new Item
              {
                    City = "נתניה",
                    Neighborhood = "פולג",
                    BuildingType = "וילה",
                    Rooms = 5,
                    Area = 150,
                    Beds = 3,
                    Floor = "קרקע",
                    ImageUrl = "https://cdn.pixabay.com/photo/2018/01/26/08/15/dining-room-3108037_1280.jpg"
                }
            },
            // 4 tel aviv
            new Auction
            {
                Id = Guid.Parse("155225c1-4448-4066-9886-6786536e05ea"),
                Status = Status.ReserveNotMet,
                ReservePrice = 600,
                Seller = "ישראל",
                AuctionEnd = DateTime.UtcNow.AddDays(-10),
                Item = new Item
                {
                    City = "Tel Aviv",
                    Neighborhood = "Florentin",
                    BuildingType = "house",
                    Rooms = 3,
                    Area = 80,
                    Beds = 4,
                    Floor = "5",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a9/Washington_Avenue%2C_Florentin_IMG_1225.JPG/800px-Washington_Avenue%2C_Florentin_IMG_1225.jpg"
                }
            },
            // 5 Haifa
            new Auction
            {
                Id = Guid.Parse("466e4744-4dc5-4987-aae0-b621acfc5e39"),
                Status = Status.Live,
                ReservePrice = 15,
                Seller = "הנרי",
                AuctionEnd = DateTime.UtcNow.AddDays(30),
                Item = new Item
                {
                    City = "חיפה",
                    Neighborhood = "רמת אלון",
                    BuildingType = "יחידת דיור",
                    Rooms = 4,
                    Area = 100,
                    Beds = 3,
                    Floor = "ground",
                    ImageUrl = "https://www.southernliving.com/thmb/q4YyCU_SKTBW6dR39pcCjDm7QKw=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/cloudland_0_0_0-c8f98341bc474c458a8dc3ed2bf01228.jpg"
                }
            },
            // 6 ramat gan
            new Auction
            {
                Id = Guid.Parse("dc1e4071-d19d-459b-b848-b5c3cd3d151f"),
                Status = Status.Live,
                ReservePrice = 200,
                Seller = "עמית",
                AuctionEnd = DateTime.UtcNow.AddDays(45),
                Item = new Item
                {
                    City = "רמת גן",
                    Neighborhood = "גפן",
                    BuildingType = "דירה",
                    Rooms = 3,
                    Area = 70,
                    Beds = 2,
                    Floor = "1",
                    ImageUrl = "https://pic1.calcalist.co.il/PicServer3/2020/07/26/1007757/1LM.jpg"
                }
            },
            // 7 herzliya
            new Auction
            {
                Id = Guid.Parse("47111973-d176-4feb-848d-0ea22641c31a"),
                Status = Status.Live,
                ReservePrice = 150000,
                Seller = "דניאל",
                AuctionEnd = DateTime.UtcNow.AddDays(13),
                Item = new Item
                 {
                    City = "הרצליה",
                    Neighborhood = "ויצמן",
                    BuildingType = "וילה",
                    Rooms = 3,
                    Area = 70,
                    Beds = 2,
                    Floor = "קרקע",
                    ImageUrl = "https://pic1.calcalist.co.il/PicServer3/2020/07/26/1007757/1LM.jpg"
                }
            },
            // 8 Ramat Hasharon
            new Auction
            {
                Id = Guid.Parse("6a5011a1-fe1f-47df-9a32-b5346b289391"),
                Status = Status.Live,
                Seller = "נועה",
                AuctionEnd = DateTime.UtcNow.AddDays(19),
                Item = new Item
                   {
                    City = "רמת השרון",
                    Neighborhood = "אלון",
                    BuildingType = "וילה",
                    Rooms = 5,
                    Area = 120,
                    Beds = 5,
                    Floor = "קרקע",
                    ImageUrl = "https://pic1.calcalist.co.il/PicServer3/2020/07/26/1007757/1LM.jpg"
                }
            },
            // 9 Beer Sheva
            new Auction
            {
                Id = Guid.Parse("40490065-dac7-46b6-acc4-df507e0d6570"),
                Status = Status.Live,
                ReservePrice = 300,
                Seller = "tom",
                AuctionEnd = DateTime.UtcNow.AddDays(20),
                Item = new Item
               {
                    City = "באר שבע",
                    Neighborhood = "כלניות",
                    BuildingType = "דירה",
                    Rooms = 2,
                    Area = 50,
                    Beds = 2,
                    Floor = "4",
                    ImageUrl = "https://pic1.calcalist.co.il/PicServer3/2020/07/26/1007757/1LM.jpg"
                }
            },
            // 10 Jerusalem
            new Auction
            {
                Id = Guid.Parse("3659ac24-29dd-407a-81f5-ecfe6f924b9b"),
                Status = Status.Live,
                ReservePrice = 150,
                Seller = "אלון",
                AuctionEnd = DateTime.UtcNow.AddDays(48),
                Item = new Item
                  {
                    City = "ירושלים",
                    Neighborhood = "כלניות",
                    BuildingType = "דירה",
                    Rooms = 2,
                    Area = 50,
                    Beds = 2,
                    Floor = "4",
                    ImageUrl = "https://pic1.calcalist.co.il/PicServer3/2020/07/26/1007757/1LM.jpg"
                }
            }
        };

        context.AddRange(auctions);

        context.SaveChanges();
    }
}
