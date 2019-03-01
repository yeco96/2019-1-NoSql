using Fidelitas.NoSql.PrimerEjemplo.Collections;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fidelitas.NoSql.PrimerEjemplo.Models
{
    public class ContextoMongo
    {
        public IMongoDatabase database;
        public ContextoMongo()
        {
            var connectionString = Properties.Settings.Default.mongoConnection;
            var client = new MongoClient(connectionString);
            database = client.GetDatabase(Properties.Settings.Default.databaseName);
        }

        public IMongoCollection<Animales> LosAnimales
        {
            get
            {
                return (database.GetCollection<Animales>("animales"));
            }
            set
            {
            }
        }

    }
}