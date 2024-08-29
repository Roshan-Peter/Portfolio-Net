using MongoDB.Driver;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Services
{
    public class MessageService
    {
        private readonly IMongoCollection<Message> _messageCollection;
        public MessageService(MongoDbContext context) 
        {
            _messageCollection = context.MessageCollection;
        }

        public void CreateMessage(Message message)
        {
            _messageCollection.InsertOne(message);
        }

        public List<Message> GetAllMessages()
        {
            return _messageCollection.Find(message => true).ToList();
        }
    }
}
