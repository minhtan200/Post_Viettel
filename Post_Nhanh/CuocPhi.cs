using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Post_Nhanh.Models;

namespace Post_Nhanh
{
    public partial class CuocPhi : Form
    {
        public double TietKiemCost { get; set; }
        public double NhanhCost { get; set; }
        public double HoaTocCost { get; set; }
        public double TotalWeight { get; set; }
        public double TotalValue { get; set; }
        public double ShippingCost { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverAddress { get; set; }
        public CuocPhi()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBoxTietKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNhanh_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHoaToc_TextChanged(object sender, EventArgs e)
        {

        }

        private void CuocPhi_Load(object sender, EventArgs e)
        {

        }
        public void DisplayShippingCosts()
        {
            textBoxTietKiem.Text = (TotalValue * 0.05).ToString("F2"); // Example calculation
            textBoxNhanh.Text = (TotalWeight * 10).ToString("F2"); // Example rate per kg
            textBoxHoaToc.Text = ShippingCost.ToString("F2"); // Total shipping cost
        }
        public void SetShippingDetails(string senderAddress, string receiverAddress, double totalWeight, double totalValue)
        {
            // Gán giá trị vào biến lớp (nếu cần)
            SenderAddress = senderAddress;
            ReceiverAddress = receiverAddress;
            TotalWeight = totalWeight;
            TotalValue = totalValue;

            // Tính toán cước phí
            CalculateShippingCosts();
        }

        private void CalculateShippingCosts()
        {
            // Ví dụ về cách tính toán cước phí (cần điều chỉnh theo logic cụ thể)
            double shippingCostTietKiem = TotalWeight * 1000; // Cước phí tiết kiệm
            double shippingCostNhanh = TotalWeight * 1500; // Cước phí nhanh
            double shippingCostHoaToc = TotalWeight * 2000; // Cước phí hoả tốc

            // Hiển thị vào các TextBox
            textBoxTietKiem.Text = shippingCostTietKiem.ToString("C"); // Định dạng tiền tệ
            textBoxNhanh.Text = shippingCostNhanh.ToString("C");
            textBoxHoaToc.Text = shippingCostHoaToc.ToString("C");
        }

        private void CuocPhi_Load_1(object sender, EventArgs e)
        {
            // Hiển thị các cước phí trong TextBox
            textBoxTietKiem.Text = TietKiemCost.ToString("C"); // Định dạng tiền tệ
            textBoxNhanh.Text = NhanhCost.ToString("C"); // Định dạng tiền tệ
            textBoxHoaToc.Text = HoaTocCost.ToString("C"); // Định dạng tiền tệ


        }
    }
}
