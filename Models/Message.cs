using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Portfolio.Models
{
    public class Message
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public string? Email { get; set; }

        public string MessageText { get; set; }
    }
}
