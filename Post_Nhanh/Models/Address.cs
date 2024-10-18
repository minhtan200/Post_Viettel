using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Nhanh.Models
{
    internal class Address
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("senderName")]
        public string SenderName { get; set; }

        [BsonElement("senderPhoneNumber")]
        public string SenderPhoneNumber { get; set; }

        [BsonElement("senderAddress")]
        public string SenderAddress { get; set; }

        [BsonElement("receiverName")]
        public string ReceiverName { get; set; }

        [BsonElement("receiverPhoneNumber")]
        public string ReceiverPhoneNumber { get; set; }

        [BsonElement("receiverAddress")]
        public string ReceiverAddress { get; set; }
        public Sender Sender { get; set; }
        public Receiver Receiver { get; set; }
    }
}
