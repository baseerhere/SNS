using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SNS.Models
{
    public class User
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NickName { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Gender { get; set; }

        public UserLoginHistory[] UserLoginHistory { get; set; }
    }
}