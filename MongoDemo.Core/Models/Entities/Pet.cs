using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDemo.Core.Models.Enums;

namespace MongoDemo.Core.Models.Entities;

public class Pet
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public Animal Animal { get; set; }
    public Gender Sex { get; set; }
    public double Age { get; set; }
    public Color? Color { get; set; }
}

public class Color
{
    public string? Body { get; set; }
    public string? Face { get; set; }
    public string? Legs { get; set; }
    public string? Tail { get; set; }
}