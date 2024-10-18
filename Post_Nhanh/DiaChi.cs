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
    public partial class DiaChi : Form
    {
        private IMongoCollection<Address> _addressCollection;
        public DiaChi()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("ViettelPost");
            _addressCollection = database.GetCollection<Address>("Address");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng Sender và Receiver mới
            var gui = new Sender
            {
                Name = senderNameTextBox.Text,
                PhoneNumber = senderPhoneTextBox.Text,
                Address = senderAddressTextBox.Text
            };

            var receiver = new Receiver
            {
                Name = receiverNameTextBox.Text,
                PhoneNumber = receiverPhoneTextBox.Text,
                Address = receiverAddressTextBox.Text
            };

            // Tạo đối tượng Address mới
            var address = new Address
            {
                Sender = gui,
                Receiver = receiver
            };

            // Lưu địa chỉ vào MongoDB
            await _addressCollection.InsertOneAsync(address);

            // Hiển thị thông báo
            MessageBox.Show("Địa chỉ đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Đóng form sau khi lưu
            HangHoa hanghoa = new HangHoa();
            hanghoa.Show();
            this.Hide();
        }
    }
}
