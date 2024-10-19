using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Nhanh.Models
{
    internal class ShippingInfo
    {
        public string ShippingService { get; set; }
        public bool IsSpecialGoods { get; set; }
        public AdditionalService AdditionalService { get; set; }
        public string OrderNote { get; set; }
        public decimal TotalOrderCost { get; set; }
    }

    internal class AdditionalService
    {
        public bool InsuranceAndDeclaredValue { get; set; }
        public bool Inspection { get; set; }
    }
}
