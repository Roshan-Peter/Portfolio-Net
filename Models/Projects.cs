using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Portfolio.Models
{
    public class Projects
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Framework { get; set; }
        public int Priority { get; set; }
        public List<Technology> Technology { get; set; }
    }
}
