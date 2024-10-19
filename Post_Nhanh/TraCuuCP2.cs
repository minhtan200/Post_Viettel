using System;
using System.Windows.Forms;

namespace Post_Nhanh
{
    public partial class TraCuuCP2 : Form
    {
        public TraCuuCP2(string fromTo, string weight, string service1Price, string service2Price, string service3Price)
        {
            InitializeComponent();
            HienThiThongTin(fromTo, weight, service1Price, service2Price, service3Price);
        }

        private void TraCuuCP2_Load(object sender, EventArgs e)
        {
            // Additional initialization can go here if needed
        }
     
        public void HienThiThongTin(string fromTo, string weight, string service1Price, string service2Price, string service3Price)
        {
            textBox5.Text = fromTo;
            textBox6.Text = weight;
            txtService1.Text = "Chuyển phát tiết kiệm hàng hóa: " + service1Price;
            txtService2.Text = "Chuyển phát nhanh: " + service2Price;
            txtService3.Text = "TMDT Tiết Kiệm: " + service3Price;
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            string selectedService = string.Empty;

            // Xác định dịch vụ được chọn
            if (rbService1.Checked)
                selectedService = "Chuyển phát tiết kiệm hàng hóa";
            else if (rbService2.Checked)
                selectedService = "Chuyển phát nhanh";
            else if (rbService3.Checked)
                selectedService = "TMDT Tiết Kiệm";

         
        }


        private void pnlFromToWeight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtService1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
