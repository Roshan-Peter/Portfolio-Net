using MongoDB.Bson;
using MongoDB.Driver;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Services
{
    public class AboutService
    {
        private readonly IMongoCollection<About> _aboutCollection;

        public AboutService(MongoDbContext context)
        {
            _aboutCollection = context.AboutCollection;
        }

        public void CreateAbout(About about)
        {
            _aboutCollection.InsertOne(about);
        }

        public List<About> GetAbouts()
        {
            return _aboutCollection.Find(about => true).ToList();
        }

        public About GetAboutById(ObjectId id)
        {
            return _aboutCollection.Find(about => about.Id == id).FirstOrDefault();
        }

        public void UpdateAbout(ObjectId id, About updatedAbout)
        {
            _aboutCollection.ReplaceOne(about => about.Id == id, updatedAbout);
        }

        public void DeleteAbout(ObjectId id)
        {
            _aboutCollection.DeleteOne(about => about.Id == id);
        }
    }
}
