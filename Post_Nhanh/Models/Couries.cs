using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Nhanh.Models
{
    internal class Couries
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } // ID của người giao hàng

        [BsonElement("name")]
        public string Name { get; set; } // Tên người giao hàng

        [BsonElement("phoneNumber")]
        public string PhoneNumber { get; set; } // Số điện thoại

        [BsonElement("vehicle")]
        public string Vehicle { get; set; } // Phương tiện giao hàng
    }
}
