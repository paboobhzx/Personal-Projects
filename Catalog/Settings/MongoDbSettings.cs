namespace Catalog.Settings

{
    public class MongoDbSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string User {get;set;}
        public string Password {get;set;}
        
        public string ConnectionString{ 
            get 
            {//mongodb://username:password@ds011111.mongolab.com:11111/db-name
                return $"mongodb://{User}:{Password}@{Host}:{Port}";
            }
            
        }
    }
}