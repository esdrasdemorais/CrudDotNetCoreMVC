using System.Collections;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudDotNetCore.Models
{
    public class MongoDbContext
    {
        public static String ConnectionString { get; set; }
        public static String DatabaseName { get; set; } 
        public static Boolean IsSSL { get; set; }
        
        private IMongoDatabase database { get; }

        public MongoDbContext()
        {
            try
            {
                MongoClientSettings settings = MongoClientSettings.FromUrl(
                    new MongoUrl(ConnectionString)
                );
                /*if (IsSSL)
                {
                    settings.SslSettings = new SslSettings {
                        EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12
                    };
                }*/
                var mongoClient = new MongoClient(settings);
                database = mongoClient.GetDatabase(DatabaseName);
            }
            catch (Exception ex) {
                throw new Exception("Erro ao Conectar: " + ex.Message);
            }
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            var collection = database.GetCollection<Employee>("Employees");
            var documents = await collection.Find(_ => true).ToListAsync();
            
            return documents;
        }

        public async Task<Employee> GetEmployee(String id)
        {
            var collection = database.GetCollection<Employee>("Employees");
            var entity = await collection.Find(e => e.Id == id)
                .FirstOrDefaultAsync();
            
            return entity; 
        }

        public Boolean Update(Employee employee)
        {
            var collection = database.GetCollection<Employee>("Employees");
            collection.ReplaceOne(m => m.Id == employee.Id, employee);
            return true;
        } 

        public Boolean Create(Employee employee)
        {
            var collection = database.GetCollection<Employee>("Employees");
            collection.InsertOne(employee);
            return true;
        }

        public Boolean Delete(String id)
        {
            var collection = database.GetCollection<Employee>("Employees");
            collection.DeleteOne(e => e.Id == id);
            return true;
        }
    }
}