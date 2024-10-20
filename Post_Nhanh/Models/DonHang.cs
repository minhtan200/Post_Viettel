using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Nhanh.Models
{
    internal class DonHang
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } // Thêm thuộc tính Id cho đơn hàng
        public string OrderCode { get; set; }
        public SenderReceiverInfo Sender { get; set; }
        public SenderReceiverInfo Receiver { get; set; }
        public ProductInfo Product { get; set; }
        public ShippingInfo Shipping { get; set; }
        public DateTime OrderDate { get; set; }

     
        public DateTime ThoiGianCapNhat { get; set; }
        public TrangThaiDonHang.TrangThai TrangThai { get; set; } // Trạng thái của đơn hàng
    }
}
