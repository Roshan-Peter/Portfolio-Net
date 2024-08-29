using MongoDB.Bson;
using MongoDB.Driver;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Services
{
    public class EducationService
    {
        private readonly IMongoCollection<Education> _educationCollection;
        public EducationService(MongoDbContext context) 
        { 
            _educationCollection = context.EducationCollection;
        }

        public void CreateEducation(Education education)
        {
            _educationCollection.InsertOne(education);
        }

        public List<Education> GetEducation()
        {
            return _educationCollection.Find(education => true).ToList();
        }

        public Education GetEducationById(ObjectId id)
        {
            return _educationCollection.Find(education => education.Id == id).FirstOrDefault();
        }

        public void DeleteEducation(ObjectId id)
        {
            _educationCollection.DeleteOne(education => education.Id == id);
        }
    }
}
