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

namespace Post_Nhanh.Nhanvien
{
    public partial class Login : Form
    {
        private readonly IMongoCollection<NhanVien> _staff;
        public Login()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("ViettelPost");
            _staff = database.GetCollection<NhanVien>("NhanVien"); // Thay đổi tên collection nếu cần
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
            var filter = Builders<NhanVien>.Filter.Eq(c => c.PhoneNumber, sodienthoai);
            var staff = _staff.Find(filter).FirstOrDefault();

            // Kiểm tra nếu khách hàng tồn tại và xác thực mật khẩu
            if (staff != null && BCrypt.Net.BCrypt.Verify(password, staff.Password))
            {
                MessageBox.Show("Đăng nhập thành công!");

                // Mở form chính và truyền thông tin người dùng
                QuanLyDH mainForm = new QuanLyDH();
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
