using MongoDB.Driver;
using Portfolio.Models;

namespace Portfolio.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("MongoDb"));
            _database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);
        }

        public IMongoCollection<About> AboutCollection => _database.GetCollection<About>("Abouts");
        public IMongoCollection<Projects> ProjectsCollection => _database.GetCollection<Projects>("Projects");
        public IMongoCollection<Education> EducationCollection => _database.GetCollection<Education>("Education");
        public IMongoCollection<Message> MessageCollection => _database.GetCollection<Message>("Message");

    }
}
