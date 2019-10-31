using System.Net.NetworkInformation;
using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CrudDotNetCore.Models
{
    public class Department
    {
        [BsonRepresentation(BsonType.ObjectId)]
        private String id;
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