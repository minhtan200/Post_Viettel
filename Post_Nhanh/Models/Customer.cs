using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Nhanh.Models
{
    internal class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }  // Thuộc tính Id sẽ tự động được MongoDB sinh ra

        [BsonElement("name")]
        public string Name { get; set; }  // Tên khách hàng

        [BsonElement("phoneNumber")]
        public string PhoneNumber { get; set; }  // Số điện thoại

        [BsonElement("address")]
        public string Address { get; set; }  // Địa chỉ

        [BsonElement("email")]
        public string Email { get; set; }  // Email khách hàng

        [BsonElement("password")]
        public string Password { get; set; }  // Mật khẩu
    }
}
