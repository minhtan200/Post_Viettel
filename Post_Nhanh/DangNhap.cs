﻿using Microsoft.Win32;
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
using BCrypt.Net;

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
            _customers = database.GetCollection<Customer>("Customers");
            //lấy collection Customers để làm việc với các đối tượng Customer.
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

            // Tìm kiếm khách hàng bằng số điện thoại
            //Bộ lọc được tạo bằng Builders<Customer>.Filter.Eq, cho phép tìm kiếm khách hàng dựa trên số điện thoại.
            //Sau đó, FirstOrDefault sẽ trả về khách hàng đầu tiên thỏa mãn điều kiện hoặc null nếu không có khách hàng nào.
            var filter = Builders<Customer>.Filter.Eq(c => c.PhoneNumber, sodienthoai);

            var customer = _customers.Find(filter).FirstOrDefault(); //FirstOrDefault() được gọi để lấy bản ghi đầu tiên trong tập hợp kết quả.
            // Phương thức Find được gọi trên _customers với tham số filter.
            //filter là một đối tượng bộ lọc (filter) được tạo ra bằng Builders<Customer>.Filter.Eq(c => c.PhoneNumber, sodienthoai);.
            //Bộ lọc này tìm kiếm các khách hàng có trường PhoneNumber bằng với giá trị của biến sodienthoai.

            // Kiểm tra nếu khách hàng tồn tại và xác thực mật khẩu
            if (customer != null && BCrypt.Net.BCrypt.Verify(password, customer.Password))
            {
                MessageBox.Show("Đăng nhập thành công!");

                // Mở form chính và truyền thông tin người dùng
                TrangChu mainForm = new TrangChu(customer.Name, customer.PhoneNumber);
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
