using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Nhanh.Models
{
    internal class Tracking
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } // ID của thông tin theo dõi

        [BsonElement("packageID")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string PackageID { get; set; } // ID của gói hàng

        [BsonElement("location")]
        public string Location { get; set; } // Địa điểm

        [BsonElement("status")]
        public string Status { get; set; } // Trạng thái

        [BsonElement("timestamp")]
        public DateTime Timestamp { get; set; } // Thời gian ghi nhận
    }
}
