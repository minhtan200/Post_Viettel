using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Nhanh.Models
{
    internal class ProductInfo
    {
        public string ProductName { get; set; }
        public decimal ProductValue { get; set; }
        public int Quantity { get; set; }
        public decimal Weight { get; set; }
        public decimal TotalValue { get; set; }
        public decimal TotalWeight { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
    }
}
