using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ImportData
{
    class Program
    {
        static void Main(string[] args)
        {
            var mongoServerAddress = new MongoServerAddress("127.0.0.1", 27017);
            var mongoServerSettings = new MongoServerSettings();
            mongoServerSettings.Server = mongoServerAddress;
            var mongoServer = new MongoServer(mongoServerSettings);
            mongoServer.Connect();
            IEnumerable<string> databases = mongoServer.GetDatabaseNames();
            var mongoDatabase = mongoServer.GetDatabase("classfrogdb");
            var classCollection = mongoDatabase.GetCollection("classes");
            classCollection.RemoveAll();
            var documents = classCollection.FindAll();
            ClassInstance instance = new ClassInstance();
            classCollection.Insert(instance.NewDocument());
            classCollection.Insert(instance.NewDocument());
            classCollection.Insert(instance.NewDocument());
            classCollection.Insert(instance.NewDocument());
            classCollection.Insert(instance.NewDocument());
            classCollection.Insert(instance.NewDocument());
            classCollection.Insert(instance.NewDocument());
            classCollection.Insert(instance.NewDocument());
            classCollection.Insert(instance.NewDocument());            
            mongoServer.Disconnect();
        }
    }
}
