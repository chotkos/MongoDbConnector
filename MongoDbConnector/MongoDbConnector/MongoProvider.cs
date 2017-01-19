using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS.ActiveMQ.Commands;
using MongoDB;
using MongoDB.Configuration;

namespace MongoDbConnector
{
    public class MongoProvider
    {
        private MongoConfiguration configuration;
        private Mongo mongoContext;
        public IMongoDatabase Context { get; set; }
        /// <summary>
        /// Creates new MongoProvider
        /// </summary>
        /// <param name="configuration">Connection configuration. Set to default port 27017 if null.</param>
        /// <param name="databaseName">Name of database in Mongo which you would like to connect</param>
        public MongoProvider(MongoConfiguration configuration, string databaseName)
        {
            databaseName = databaseName;
            if (configuration==null)
            {
                configuration = MongoConfiguration.Default;
            }

            mongoContext = new Mongo();
            mongoContext.Connect();
            this.Context = mongoContext.GetDatabase(databaseName); 
        }
    }
}
