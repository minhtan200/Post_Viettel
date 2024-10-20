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
    public partial class QuanLyDH : Form
    {
        private readonly IMongoCollection<DonHang> _donHangCollection;
        private List<DonHang> _danhSachDonHang;
        private BindingSource bindingSource;


        public QuanLyDH()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            _donHangCollection = ConnectToMongoDB();
            InitializeComboBoxTrangThai();
            LoadDonHang();
            SetupDataGridView();
        }
        // Kết nối đến MongoDB
        private IMongoCollection<DonHang> ConnectToMongoDB()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("ViettelPost");
            return database.GetCollection<DonHang>("DonHang");
        }

        private void InitializeComboBoxTrangThai()
        {
            comboBoxTrangThai.Items.Clear();
            comboBoxTrangThai.Items.AddRange(Enum.GetNames(typeof(TrangThaiDonHang.TrangThai)));
            comboBoxTrangThai.SelectedIndex = 0;
        }

        private void LoadDonHang()
        {
            try
            {
                var danhSachDonHang = _donHangCollection.Find(Builders<DonHang>.Filter.Empty).ToList();

                // Convert to display format
                var displayData = danhSachDonHang.Select(dh => new
                {
                    MaDonHang = dh.OrderCode,
                    NguoiGui = dh.Sender?.Name ?? "",
                   
                    DiaChiGui = dh.Sender?.Address ?? "",
                    NguoiNhan = dh.Receiver?.Name ?? "",
                 
                    DiaChiNhan = dh.Receiver?.Address ?? "",
                    TenHang = dh.Product?.ProductName ?? "",
                    GiaTri = dh.Product?.TotalValue ?? 0,
                    TrongLuong = dh.Product?.TotalWeight ?? 0,
                    DichVu = dh.Shipping?.ShippingService ?? "",
                    TrangThai = dh.TrangThai,
                    ThoiGianCapNhat = dh.ThoiGianCapNhat
                }).ToList();

                bindingSource.DataSource = displayData;
                dataGridViewDonHang.DataSource = bindingSource;
                dataGridViewDonHang.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thiết lập DataGridView cho dễ nhìn
        private void SetupDataGridView()
        {
            dataGridViewDonHang.AutoGenerateColumns = false;
            dataGridViewDonHang.Columns.Clear();

            var columns = new[]
            {
                new DataGridViewTextBoxColumn
                {
                    Name = "MaDonHang",
                    HeaderText = "Mã Đơn Hàng",
                    DataPropertyName = "MaDonHang",
                    Width = 100
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "NguoiGui",
                    HeaderText = "Người Gửi",
                    DataPropertyName = "NguoiGui",
                    Width = 150
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "NguoiNhan",
                    HeaderText = "Người Nhận",
                    DataPropertyName = "NguoiNhan",
                    Width = 150
                },
               
                
                new DataGridViewTextBoxColumn
                {
                    Name = "DiaChiGui",
                    HeaderText = "Địa Chỉ Gửi",
                    DataPropertyName = "DiaChiGui",
                    Width = 200
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "DiaChiNhan",
                    HeaderText = "Địa Chỉ Nhận",
                    DataPropertyName = "DiaChiNhan",
                    Width = 200
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "TrangThai",
                    HeaderText = "Trạng Thái",
                    DataPropertyName = "TrangThai",
                    Width = 120
                }
            };

            dataGridViewDonHang.Columns.AddRange(columns);
            dataGridViewDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDonHang.AllowUserToAddRows = false;
            dataGridViewDonHang.ReadOnly = true;
        }

        private void dataGridViewDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Validate row index
            {
                var selectedRow = dataGridViewDonHang.Rows[e.RowIndex];
                // Select current status in ComboBox
                comboBoxTrangThai.SelectedItem = selectedRow.Cells["TrangThai"].Value.ToString();
            }
        }

        private async void buttonXacNhan_Click(object sender, EventArgs e)
        {
            if (dataGridViewDonHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần cập nhật!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy mã đơn hàng từ dòng được chọn
                string maDonHang = dataGridViewDonHang.CurrentRow.Cells["MaDonHang"].Value.ToString();

                // Tìm đơn hàng trong database
                var filter = Builders<DonHang>.Filter.Eq(x => x.OrderCode, maDonHang);
                var donHang = await _donHangCollection.Find(filter).FirstOrDefaultAsync();

                if (donHang != null && Enum.TryParse<TrangThaiDonHang.TrangThai>(
                    comboBoxTrangThai.SelectedItem.ToString(),
                    out TrangThaiDonHang.TrangThai newTrangThai))
                {
                    // Cập nhật trạng thái và thời gian
                    donHang.TrangThai = newTrangThai;
                    donHang.ThoiGianCapNhat = DateTime.Now;

                    // Cập nhật trong MongoDB
                    await _donHangCollection.ReplaceOneAsync(filter, donHang);

                    // Reload data
                    LoadDonHang();

                    MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật trạng thái: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Cập nhật đơn hàng trong MongoDB
        private void UpdateDonHangInMongoDB(DonHang donHang)
        {
            var filter = Builders<DonHang>.Filter.Eq(d => d.Id, donHang.Id); // Create filter to find order by Id
            _donHangCollection.ReplaceOne(filter, donHang); // Update the order in MongoDB by replacing it
        }


        private void buttonHuy_Click(object sender, EventArgs e)
        {
            if (dataGridViewDonHang.CurrentRow != null)
            {
                var result = MessageBox.Show(
                    "Bạn có chắc chắn muốn hủy cập nhật không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    LoadDonHang();
                }
            }
        }
    }
}
