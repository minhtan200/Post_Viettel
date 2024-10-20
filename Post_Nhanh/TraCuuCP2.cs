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
    public partial class TraCuuCP2 : Form
    {
        public TraCuuCP2(string fromTo, string weight, string service1Price, string service2Price, string service3Price)
        {
            InitializeComponent();
            HienThiThongTin(fromTo, weight, service1Price, service2Price, service3Price);
        }

        private void TraCuuCP2_Load(object sender, EventArgs e)
        {

        }
        public void HienThiThongTin(string fromTo, string weight, string service1Price, string service2Price, string service3Price)
        {
            textBox5.Text = fromTo;
            textBox6.Text = weight;
            txtService1.Text = "Tiết kiệm: " + service1Price;
            txtService2.Text = "Nhanh: " + service2Price;
            txtService3.Text = "Hảo tốc: " + service3Price;
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            string selectedService = string.Empty;

            // Xác định dịch vụ được chọn
            if (rbService1.Checked)
                selectedService = "Tiết kiệm";
            else if (rbService2.Checked)
                selectedService = "Nhanh";
            else if (rbService3.Checked)
                selectedService = "Hỏa Tốc";

        }
    }
}
