using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Nhanh.Models
{
    internal class PostalItems
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } // ID của sản phẩm

        [BsonElement("description")]
        public string Description { get; set; } // Mô tả sản phẩm

        [BsonElement("weight")]
        public double Weight { get; set; } // Trọng lượng

        [BsonElement("dimensions")]
        public Dimensions Dimensions { get; set; } // Kích thước

        [BsonElement("value")]
        public double Value { get; set; } // Giá trị

        [BsonElement("customerID")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CustomerID { get; set; } // ID khách hàng

        [BsonElement("status")]
        public string Status { get; set; } // Trạng thái
    }
    internal class Dimensions
    {
        [BsonElement("length")]
        public double Length { get; set; } // Chiều dài

        [BsonElement("width")]
        public double Width { get; set; } // Chiều rộng

        [BsonElement("height")]
        public double Height { get; set; } // Chiều cao
    }
}
