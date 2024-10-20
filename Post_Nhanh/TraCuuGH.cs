using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
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
    public partial class TraCuuGH : Form
    {
        private IMongoCollection<Shipment> _shipmentCollection;
        private IMongoCollection<Tracking> _trackingCollection;
        private readonly IMongoDatabase _database;
        public TraCuuGH()
        {
            InitializeComponent();
            try
            {
                var client = new MongoClient("mongodb://localhost:27017");
                _database = client.GetDatabase("ViettelPost");
                _shipmentCollection = _database.GetCollection<Shipment>("Shipments");
                _trackingCollection = _database.GetCollection<Tracking>("Tracking");
                MessageBox.Show("Kết nối MongoDB thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối MongoDB thất bại: " + ex.Message);
            }
        }

        private  async void btnTraCuu_Click(object sender, EventArgs e)
        {
            string packageID = txtMaDonHang.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();  // Lấy số điện thoại từ TextBox

            if (string.IsNullOrEmpty(packageID) && string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập mã đơn hàng hoặc số điện thoại.");
                return;
            }

            try
            {
                FilterDefinition<Shipment> shipmentFilter;

                // Tạo bộ lọc dựa trên mã đơn hàng hoặc số điện thoại
                if (!string.IsNullOrEmpty(packageID))
                {
                    shipmentFilter = Builders<Shipment>.Filter.Eq(s => s.PackageID, packageID);  // Đổi 'packageID' thành 'PackageID'
                }
                else
                {
                    shipmentFilter = Builders<Shipment>.Filter.Eq(s => s.CustomerPhoneNumber, phoneNumber);  // Đổi 'customerPhoneNumber' thành 'CustomerPhoneNumber'
                }

                // Tìm kiếm đơn hàng trong MongoDB
                var shipmentResult = await _shipmentCollection.Find(shipmentFilter).FirstOrDefaultAsync();

                if (shipmentResult != null)
                {
                    var trackingFilter = Builders<Tracking>.Filter.Eq(t => t.PackageID, shipmentResult.PackageID);  // Đổi 'packageID' thành 'PackageID'
                    var trackingResult = await _trackingCollection.Find(trackingFilter).ToListAsync();

                    if (trackingResult != null && trackingResult.Count > 0)
                    {
                        var lastTracking = trackingResult.OrderByDescending(t => t.Timestamp).FirstOrDefault();
                        lblTrangThaiThongBao.Text = $"Trạng thái hiện tại: {lastTracking.Status}";

                        dgvTrangThai.DataSource = trackingResult.Select(tr => new
                        {
                            Trạng_thái = tr.Status,
                            Vị_trí = tr.Location,
                            Thời_gian = tr.Timestamp.ToString("yyyy-MM-dd HH:mm:ss")
                        }).ToList();
                    }
                    else
                    {
                        lblTrangThaiThongBao.Text = "Không tìm thấy thông tin tracking.";
                        dgvTrangThai.DataSource = null;
                    }
                }
                else
                {
                    lblTrangThaiThongBao.Text = "Không tìm thấy đơn hàng.";
                    dgvTrangThai.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình tra cứu: " + ex.Message);
            }
        }
        // Định nghĩa class Shipment để ánh xạ dữ liệu MongoDB
        public class Shipment
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string _id { get; set; }

            public string PackageID { get; set; }  // Đổi từ 'packageID' thành 'PackageID'

            public string CourierID { get; set; }  // Giữ nguyên
            public string CustomerPhoneNumber { get; set; }  // Đổi từ 'customerPhoneNumber' thành 'CustomerPhoneNumber'

            public DateTime DateShipped { get; set; }  // Giữ nguyên
            public DateTime EstimatedDelivery { get; set; }  // Giữ nguyên
            public string Status { get; set; }  // Giữ nguyên
        }

        // Định nghĩa class Tracking để ánh xạ dữ liệu MongoDB
        public class Tracking
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string _id { get; set; }

            public string PackageID { get; set; }  // Đổi từ 'packageID' thành 'PackageID'
            public string Location { get; set; }  // Giữ nguyên
            public string Status { get; set; }  // Giữ nguyên
            public DateTime Timestamp { get; set; }  // Giữ nguyên
        }

        private void dgvTrangThai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin của dòng được chọn
                DataGridViewRow row = dgvTrangThai.Rows[e.RowIndex];

                // Hiển thị thông tin chi tiết
                string status = row.Cells["Trạng_thái"].Value.ToString();
                string location = row.Cells["Vị_trí"].Value.ToString();
                string timestamp = row.Cells["Thời_gian"].Value.ToString();

                MessageBox.Show($"Trạng thái: {status}\nVị trí: {location}\nThời gian: {timestamp}", "Chi tiết đơn hàng");
            }
        }
    }
}
