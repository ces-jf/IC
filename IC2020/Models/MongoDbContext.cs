using MongoDB.Driver;
using System;


namespace IC2020.Models
{
    public class MongoDbContext
    {
        public static string ConnectionString { get; set; }
        public static string DatabaseName { get; set; }
        public static bool IsSSL { get; set; }
        public static string Passaword { get; set; }
        public static string User { get; set; }

        private IMongoDatabase _database { get; }

        public MongoDbContext()
        {
            try
            {
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(ConnectionString));
                if (IsSSL)
                {
                    settings.SslSettings = new SslSettings { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
                    //settings.Credential=MongoCredential.CreateCredential(DatabaseName, User, Passaword);

                }
                var mongoClient = new MongoClient(settings);
               _database = mongoClient.GetDatabase(DatabaseName);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar com o servidor.", ex);
            }
        }

        public IMongoCollection<Item> Itens
        {
            get
            {
               return _database.GetCollection<Item>("Itens");
            }

        }
    }
}

