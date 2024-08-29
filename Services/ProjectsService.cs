using MongoDB.Driver;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Services
{
    public class ProjectsService
    {
        private readonly IMongoCollection<Projects> _projectsCollection;

        public ProjectsService(MongoDbContext context)
        {
            _projectsCollection = context.ProjectsCollection;
        }

        public void CreateProject(Projects project)
        {
            _projectsCollection.InsertOne(project);
        }

        public List<Projects> GetProjects()
        {
            return _projectsCollection.Find(project => true).ToList();
        }
    }
}
