using System.Text.Json;
using MongoDB.Driver;
using MongoDB.Entities;

namespace SearchService;

public class DbInitializer
{
    public static async Task InitDb(WebApplication app)
    {
        await DB.InitAsync("SearchDb", MongoClientSettings
            .FromConnectionString(app.Configuration.GetConnectionString("MongoDbConnection")));

        await DB.Index<Item>()
            .Key(x => x.City, KeyType.Text)
            .Key(x => x.Neighborhood, KeyType.Text)
            .Key(x => x.BuildingType, KeyType.Text)
            .CreateAsync();

        var count = await DB.CountAsync<Item>();
        if (count == 0)
        {
            Console.WriteLine("No data - will atempt to seed");
            var itemData = await File.ReadAllTextAsync("Data/auctions.json");

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var items = JsonSerializer.Deserialize<List<Item>>(itemData, options);

            await DB.SaveAsync(items);

        }

        using var scope = app.Services.CreateScope();

        // var httpClient = scope.ServiceProvider.GetRequiredService<AuctionSvcHttpClient>();

        // var items = await httpClient.GetItemsForSearchDb();

        // Console.WriteLine(items.Count + " returned from the auction service");

        // if (items.Count > 0) await DB.SaveAsync(items);
    }
}