using Microsoft.Win32;
using MongoDB.Driver;
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
    public partial class DangNhap : Form
    {
        private readonly IMongoCollection<Customer> _customers;
        public DangNhap()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("ViettelPost");
            _customers = database.GetCollection<Customer>("Customers"); // Thay đổi tên collection nếu cần
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                textBoxMK.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxMK.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangky = new DangKy();
            dangky.Show();
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sodienthoai = textBoxSDT.Text;
            string password = textBoxMK.Text;

            if (string.IsNullOrEmpty(sodienthoai))
            {
                MessageBox.Show("Số điện thoại không để trống");
                textBoxSDT.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Mật khẩu không được để trống.");
                textBoxMK.Focus();
                return;
            }

            // Kiểm tra thông tin đăng nhập
            var filter = Builders<Customer>.Filter.And(
                Builders<Customer>.Filter.Eq(c => c.PhoneNumber, sodienthoai),
                Builders<Customer>.Filter.Eq(c => c.Password, password)
            );

            var customer = _customers.Find(filter).FirstOrDefault();

            if (customer != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                // Mở form chính hoặc form khác sau khi đăng nhập thành công
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Số điện thoại hoặc mật khẩu không đúng.");
            }
        }
    }
}
