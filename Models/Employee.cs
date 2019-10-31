using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace CrudDotNetCore.Models
{
    public class Employee
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public Double Salary { get; set; }

        [Required]
        public IEnumerable<Department> Departments { get; set; }
    }
}