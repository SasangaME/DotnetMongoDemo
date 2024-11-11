using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDemo.Core.Models.Entities;

namespace MongoDemo.Db.Database;

public class MongoContext
{
    private readonly IMongoDatabase _database;

    public MongoContext(IConfiguration configuration)
    {
        var client = new MongoClient(configuration["ConnectionStrings:MongoConnection"]);
        _database = client.GetDatabase(configuration["ConnectionStrings:Database"]);
    }

    public IMongoCollection<Pet> Pets => _database.GetCollection<Pet>("pets");
}