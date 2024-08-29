using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Portfolio.Models
{
    public class About
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string AboutText { get; set; }
    }
}
