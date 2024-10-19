using Post_Nhanh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Post_Nhanh
{
    
    public partial class HoanThanh : Form
    {
        private TextBox txtOrderCode; // TextBox for order code
        private TextBox txtRecipientInfo; // TextBox for recipient info
        private string name;
        private string phone;
        public HoanThanh(string orderCode, DateTime orderDate, string recipientInfo, string receiverAddress, string receiverPhone)
        {
            InitializeComponent();
            lblMaDonHang.Text = orderCode; // Set the order code
            lblNgayTao.Text += orderDate.ToString("dd/MM/yyyy"); // Set the order date
            lblThongTinNguoiNhan.Text += recipientInfo; // Set the recipient info
            label4.Text += receiverAddress.ToString();
            label6.Text += receiverPhone.ToString();
        }

        private void btnTaoDonMoi_Click(object sender, EventArgs e)
        {
            AddDon don = new AddDon();
            don.Show(); 
            this.Hide();    
        }

        private void lblMaDonHang_Click(object sender, EventArgs e)
        {

        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            TrangChu mainForm = new TrangChu(name, phone);
            mainForm.Show();
            this.Hide();
        }

        private void HoanThanh_Load(object sender, EventArgs e)
        {

        }

        
    }
}
