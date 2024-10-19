using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Nhanh.Models
{
    internal class DonHang
    {
        public string OrderCode { get; set; }
        public SenderReceiverInfo Sender { get; set; }
        public SenderReceiverInfo Receiver { get; set; }
        public ProductInfo Product { get; set; }
        public ShippingInfo Shipping { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
