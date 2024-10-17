using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Nhanh.Models
{
    internal class Shipments
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } // ID của lô hàng

        [BsonElement("packageID")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string PackageID { get; set; } // ID của gói hàng

        [BsonElement("courierID")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CourierID { get; set; } // ID của người giao hàng

        [BsonElement("dateShipped")]
        public DateTime DateShipped { get; set; } // Ngày gửi hàng

        [BsonElement("estimatedDelivery")]
        public DateTime EstimatedDelivery { get; set; } // Ngày giao hàng dự kiến

        [BsonElement("status")]
        public string Status { get; set; } // Trạng thái
    }
}
