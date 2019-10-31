using System.Net.NetworkInformation;
using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CrudDotNetCore.Models
{
    public class Department
    {
        private String id;
        
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}