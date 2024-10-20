using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Nhanh.Models
{
    internal class TrangThaiDonHang
    {
        public enum TrangThai
        {
            ChoXacNhan,  // Chờ nhân viên xác nhận
            DaXacNhan,   // Đơn hàng đã được xác nhận
            DangGiaoHang,  // Đang giao hàng
            DaGiaoHang,   // Đã giao hàng thành công
            DaHuy        // Đơn hàng bị hủy
        }

        public TrangThai TrangThaiHienTai { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
    }
}
