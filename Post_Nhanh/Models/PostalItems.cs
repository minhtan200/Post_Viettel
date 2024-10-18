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

        [BsonElement("productName")]
        public string ProductName { get; set; } // Tên sản phẩm

        [BsonElement("description")]
        public string Description { get; set; } // Mô tả sản phẩm

        [BsonElement("weight")]
        public double? Weight { get; set; } // Trọng lượng

        [BsonElement("length")]
        public double? Length { get; set; } // Chiều dài

        [BsonElement("width")]
        public double? Width { get; set; } // Chiều rộng

        [BsonElement("height")]
        public double? Height { get; set; } // Chiều cao

        [BsonElement("value")]
        public double? Value { get; set; } // Giá trị

        [BsonElement("customerID")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CustomerID { get; set; } // ID khách hàng

        [BsonElement("status")]
        public string Status { get; set; } // Trạng thái

        [BsonElement("image1")]
        public string Image1 { get; set; } // Ảnh 1

        [BsonElement("image2")]
        public string Image2 { get; set; } // Ảnh 2

        [BsonElement("totalWeight")]
        public double? TotalWeight { get; set; } // Tổng khối lượng

        [BsonElement("totalValue")]
        public double? TotalValue { get; set; } // Tổng giá trị
    }

}
