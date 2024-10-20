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
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Post_Nhanh
{
    public partial class TraCuuGH : Form
    {
        private readonly IMongoCollection<DonHang> _donHangCollection; // Khai báo collection cho đơn hàng
        private List<DonHang> danhSachDonHang; // Danh sách đơn hàng

        public TraCuuGH()
        {
            InitializeComponent();
            dgvTrangThai.CellFormatting += dgvTrangThai_CellFormatting;
            btnTraCuu.Click += btnTraCuu_Click; // Register button click event
            // Thiết lập kết nối đến MongoDB
            var client = new MongoClient("mongodb://localhost:27017"); // Thay đổi chuỗi kết nối nếu cần
            var database = client.GetDatabase("ViettelPost"); // Tên database
            _donHangCollection = database.GetCollection<DonHang>("DonHang"); // Tên collection
        }
    

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            try
            {
                string maDonHang = txtMaDonHang.Text.Trim();
                string soDienThoai = txtPhoneNumber.Text.Trim();
                List<DonHang> orders = FetchOrders(maDonHang, soDienThoai);

                if (orders.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DisplayOrderData(orders);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayOrderData(List<DonHang> orders)
        {
            var displayData = orders.Select(o => new
            {
                Id = o.Id,
                MaDonHang = o.OrderCode,
                NguoiGui = o.Sender?.Name ?? "N/A",
                SDTGui = o.Sender?.PhoneNumber ?? "N/A",
                DiaChiGui = o.Sender?.Address ?? "N/A",
                NguoiNhan = o.Receiver?.Name ?? "N/A",
                SDTNhan = o.Receiver?.PhoneNumber ?? "N/A",
                DiaChiNhan = o.Receiver?.Address ?? "N/A",
                TenHangHoa = o.Product?.ProductName ?? "N/A",
                SoLuong = o.Product?.Quantity.ToString() ?? "N/A",
                TongGiaTri = o.Product?.TotalValue.ToString("C") ?? "N/A",
                TrangThai = o.TrangThai != null ? o.TrangThai.ToString() : "N/A"
            }).ToList();

            dgvTrangThai.DataSource = displayData;
        }
        private List<DonHang> FetchOrders(string orderCode, string phoneNumber)
        {
            // Tạo điều kiện truy vấn
            var filter = Builders<DonHang>.Filter.Empty; // khởi tạo rỗng
            if (!string.IsNullOrEmpty(orderCode))
            {
                filter = Builders<DonHang>.Filter.Eq(o => o.OrderCode, orderCode);
            }
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                var filterPhone = Builders<DonHang>.Filter.Eq(o => o.Sender.PhoneNumber, phoneNumber);
                filter = filter == Builders<DonHang>.Filter.Empty
                    ? filterPhone
                    : Builders<DonHang>.Filter.Or(filter, filterPhone);
            }

            // Chỉ lấy các trường cần thiết để hiển thị
            var projection = Builders<DonHang>.Projection
                .Include(o => o.OrderCode)
                .Include(o => o.Sender.Name)
                .Include(o => o.Sender.PhoneNumber)
                .Include(o => o.Sender.Address)
                .Include(o => o.Receiver.Name)
                .Include(o => o.Receiver.PhoneNumber)
                .Include(o => o.Receiver.Address)
                .Include(o => o.Product.ProductName)
                .Include(o => o.Product.Quantity)
                .Include(o => o.Product.TotalValue)
                .Include(o => o.TrangThai);

            List<DonHang> orders = _donHangCollection.Find(filter)
                .Project<DonHang>(projection)
                .ToList();
            return orders;
        }

        private void dgvTrangThai_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || e.Value == DBNull.Value)
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }
        }
    }
}
