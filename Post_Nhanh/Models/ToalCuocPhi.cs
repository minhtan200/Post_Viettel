using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Nhanh.Models
{
    internal class ToalCuocPhi
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public double TotalWeight { get; set; }
        public double TotalValue { get; set; }
        public double ShippingCost { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverAddress { get; set; }
        public double TietKiemCost { get; set; }
        public double NhanhCost { get; set; }
        public double HoaTocCost { get; set; }

    }
}
