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
    public partial class TrangChu : Form
    {
        private string customerName;
        private string phoneNumber;
        public TrangChu(string name, string phone)
        {
            InitializeComponent();
            customerName = name;
            phoneNumber = phone;

            // Set the login button to show the customer name and phone number
            lblCustomerName.Text = $"{customerName}";
            lblPhoneNumber.Text = $"{phoneNumber}";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            TraCuuCP cp = new TraCuuCP();
            cp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TraCuuGH gh =   new TraCuuGH(); 
            gh.Show();
            this.Hide();
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            AddDon diaChi = new AddDon();   
            diaChi.Show();
            this.Hide();
        }
    }
}
