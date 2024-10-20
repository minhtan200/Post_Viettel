using MongoDB.Bson;
using MongoDB.Driver;
using Post_Nhanh.Models;
using Post_Nhanh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Post_Nhanh.Nhanvien
{
    public partial class Register : Form
    {
        private IMongoCollection<NhanVien> _staffCollection;
        public Register()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("ViettelPost");
            _staffCollection = database.GetCollection<NhanVien>("NhanVien");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Khi checkbox được tích, hiện mật khẩu và xác nhận mật khẩu
            if (checkBox1.Checked)
            {
                textBoxMK.UseSystemPasswordChar = false;
                textBoxMK2.UseSystemPasswordChar = false;
            }
            // Khi checkbox không được tích, ẩn lại mật khẩu và xác nhận mật khẩu
            else
            {
                textBoxMK.UseSystemPasswordChar = true;
                textBoxMK2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string sodienthoai = textBoxSDT.Text;
            string hoten = textBoxTK.Text;
            string password = textBoxMK.Text;
            string confirmPassword = textBoxMK2.Text;

            // Kiểm tra các thông tin như email, số điện thoại, họ tên, mật khẩu
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email không được để trống.");
                textBoxEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(sodienthoai))
            {
                MessageBox.Show("Số điện thoại không được để trống.");
                textBoxSDT.Focus();
                return;
            }

            if (string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Họ tên không được để trống.");
                textBoxTK.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mật khẩu không được để trống.");
                textBoxMK.Focus();
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.");
                textBoxMK.Focus();
                return;
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Bạn phải nhập mật khẩu xác nhận.");
                textBoxMK2.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
                textBoxMK2.Focus();
                return;
            }

            // Kiểm tra xem người dùng đã tồn tại hay chưa
            var filter = Builders<NhanVien>.Filter.Eq(c => c.PhoneNumber, sodienthoai);
            var existingCustomer = _staffCollection.Find(filter).FirstOrDefault();
            if (existingCustomer != null)
            {
                MessageBox.Show("Số điện thoại này đã được đăng ký.");
                return;
            }

            // Mã hóa mật khẩu
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            // Tạo đối tượng Customer mới
            var newStaff = new NhanVien
            {
                Id = ObjectId.GenerateNewId().ToString(),
                Email = email,
                PhoneNumber = sodienthoai,
                Name = hoten,
                Password = hashedPassword // Lưu mật khẩu đã được mã hóa
            };

            // Lưu thông tin người dùng vào MongoDB
            _staffCollection.InsertOne(newStaff);

            MessageBox.Show("Đăng ký thành công!");
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }
    }
}

