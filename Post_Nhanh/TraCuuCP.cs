using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Post_Nhanh
{
    public partial class TraCuuCP : Form
    {
        public TraCuuCP()
        {
            InitializeComponent();
        }

        private void btnTraCuuCuoc_Click(object sender, EventArgs e)
        {
            // Fetch values from controls
            string tuyenDuong = rbTrongNuoc.Checked ? "Trong nuoc" : "Quoc te";
            string guiTuTinh = cbGuiTuTinh.SelectedItem.ToString();
            string guiTuHuyen = cbGuiTuHuyen.SelectedItem.ToString();
            string guiDenTinh = cbGuiDenTinh.SelectedItem.ToString();
            string guiDenHuyen = cbGuiDenHuyen.SelectedItem.ToString();
            string loaiHang = rbHangHoa.Checked ? "Hang hoa" : "Tai lieu";
            double khoiLuong = double.Parse(txtKhoiLuong.Text);
            double dai = double.Parse(txtDai.Text);
            double rong = double.Parse(txtRong.Text);
            double cao = double.Parse(txtCao.Text);

            // Calculate the shipping costs based on the provided information
            double service1Price = CalculateShippingCost(tuyenDuong, guiTuTinh, guiTuHuyen, guiDenTinh, guiDenHuyen, loaiHang, khoiLuong, dai, rong, cao);
            double service2Price = service1Price * 2; // e.g., Chuyển phát nhanh
            double service3Price = service1Price * 1.5; // e.g., TMDT Tiết Kiệm

            // Pass the calculated data to the second form
            TraCuuCP2 form2 = new TraCuuCP2($"{guiTuTinh} - {guiDenTinh}", $"{khoiLuong} kg", $"{service1Price} VND", $"{service2Price} VND", $"{service3Price} VND");
            form2.ShowDialog();
            this.Show();
        }

        private double CalculateShippingCost(string tuyenDuong, string guiTuTinh, string guiTuHuyen, string guiDenTinh, string guiDenHuyen, string loaiHang, double khoiLuong, double dai, double rong, double cao)
        {
            double cost = 0.0;

            // Define base costs for different regions and districts
            Dictionary<string, double> baseCosts = new Dictionary<string, double>
    {
        // Base costs by route (Province - District)
        { "Hồ Chí Minh - Quận 1 - Hà Nội - Quận Hoàn Kiếm", 30000 },
        { "Hồ Chí Minh - Quận 2 - Hà Nội - Quận Đống Đa", 32000 },
        { "Hồ Chí Minh - Quận 3 - Hà Nội - Quận Hai Bà Trưng", 31000 },
        { "Đà Nẵng - Quận Hải Châu - Hà Nội - Quận Hoàn Kiếm", 25000 },
        { "Đà Nẵng - Quận Sơn Trà - Hà Nội - Quận Đống Đa", 26000 },
        { "Hồ Chí Minh - Quận 4 - Đà Nẵng - Quận Thanh Khê", 27000 }
        
    };

        
            string route = $"{guiTuTinh} - {guiTuHuyen} - {guiDenTinh} - {guiDenHuyen}";

            if (baseCosts.ContainsKey(route))
            {
                cost = baseCosts[route]; // Set base cost
            }
            else
            {
             
                cost = 50000; // Default cost if route is not defined
            }

            cost += khoiLuong * 5000; // Add cost per kg to the base cost
            double lengthCost = dai * 2000; // Cost per cm of length
            double widthCost = rong * 1500;  // Cost per cm of width
            double heightCost = cao * 1000;  // Cost per cm of height

            cost += lengthCost + widthCost + heightCost;

            return cost;
        }


        private void TraCuuCP_Load(object sender, EventArgs e)
        {
            // Any initialization needed when the form loads
        }
    }
}
