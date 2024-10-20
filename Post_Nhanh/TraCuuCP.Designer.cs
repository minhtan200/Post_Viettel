using System;
using System.Drawing;
using System.Windows.Forms;
namespace Post_Nhanh
{
    partial class TraCuuCP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTuyenDuong = new System.Windows.Forms.Label();
            this.rbTrongNuoc = new System.Windows.Forms.RadioButton();
            this.rbQuocTe = new System.Windows.Forms.RadioButton();
            this.lblGuiTu = new System.Windows.Forms.Label();
            this.cbGuiTuTinh = new System.Windows.Forms.ComboBox();
            this.cbGuiTuHuyen = new System.Windows.Forms.ComboBox();
            this.lblGuiDen = new System.Windows.Forms.Label();
            this.cbGuiDenTinh = new System.Windows.Forms.ComboBox();
            this.cbGuiDenHuyen = new System.Windows.Forms.ComboBox();
            this.lblThongTinHangHoa = new System.Windows.Forms.Label();
            this.rbHangHoa = new System.Windows.Forms.RadioButton();
            this.rbTaiLieu = new System.Windows.Forms.RadioButton();
            this.lblKhoiLuong = new System.Windows.Forms.Label();
            this.txtKhoiLuong = new System.Windows.Forms.TextBox();
            this.lblKichThuoc = new System.Windows.Forms.Label();
            this.txtDai = new System.Windows.Forms.TextBox();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.txtCao = new System.Windows.Forms.TextBox();
            this.btnTraCuuCuoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTuyenDuong
            // 
            this.lblTuyenDuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTuyenDuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTuyenDuong.Location = new System.Drawing.Point(20, 20);
            this.lblTuyenDuong.Name = "lblTuyenDuong";
            this.lblTuyenDuong.Size = new System.Drawing.Size(100, 23);
            this.lblTuyenDuong.TabIndex = 0;
            this.lblTuyenDuong.Text = "Tuyến đường vận chuyển";
            // 
            // rbTrongNuoc
            // 
            this.rbTrongNuoc.BackColor = System.Drawing.Color.Transparent;
            this.rbTrongNuoc.Font = new System.Drawing.Font("Arial", 10F);
            this.rbTrongNuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbTrongNuoc.Location = new System.Drawing.Point(20, 50);
            this.rbTrongNuoc.Name = "rbTrongNuoc";
            this.rbTrongNuoc.Size = new System.Drawing.Size(104, 24);
            this.rbTrongNuoc.TabIndex = 1;
            this.rbTrongNuoc.Text = "Trong nước";
            this.rbTrongNuoc.UseVisualStyleBackColor = false;
            // 
            // rbQuocTe
            // 
            this.rbQuocTe.BackColor = System.Drawing.Color.Transparent;
            this.rbQuocTe.Font = new System.Drawing.Font("Arial", 10F);
            this.rbQuocTe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbQuocTe.Location = new System.Drawing.Point(150, 50);
            this.rbQuocTe.Name = "rbQuocTe";
            this.rbQuocTe.Size = new System.Drawing.Size(104, 24);
            this.rbQuocTe.TabIndex = 2;
            this.rbQuocTe.Text = "Quốc tế";
            this.rbQuocTe.UseVisualStyleBackColor = false;
            // 
            // lblGuiTu
            // 
            this.lblGuiTu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblGuiTu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGuiTu.Location = new System.Drawing.Point(20, 90);
            this.lblGuiTu.Name = "lblGuiTu";
            this.lblGuiTu.Size = new System.Drawing.Size(100, 23);
            this.lblGuiTu.TabIndex = 3;
            this.lblGuiTu.Text = "Gửi từ";
            // 
            // cbGuiTuTinh
            // 
            this.cbGuiTuTinh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbGuiTuTinh.Font = new System.Drawing.Font("Arial", 10F);
            this.cbGuiTuTinh.ForeColor = System.Drawing.Color.Black;
            this.cbGuiTuTinh.Items.AddRange(new object[] {
            "Hà Nội",
            "TP. HCM",
            "Đà Nẵng"});
            this.cbGuiTuTinh.Location = new System.Drawing.Point(20, 120);
            this.cbGuiTuTinh.Name = "cbGuiTuTinh";
            this.cbGuiTuTinh.Size = new System.Drawing.Size(150, 27);
            this.cbGuiTuTinh.TabIndex = 4;
            // 
            // cbGuiTuHuyen
            // 
            this.cbGuiTuHuyen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbGuiTuHuyen.Font = new System.Drawing.Font("Arial", 10F);
            this.cbGuiTuHuyen.ForeColor = System.Drawing.Color.Black;
            this.cbGuiTuHuyen.Items.AddRange(new object[] {
            "Quận 1",
            "Quận 2",
            "Quận 3"});
            this.cbGuiTuHuyen.Location = new System.Drawing.Point(200, 120);
            this.cbGuiTuHuyen.Name = "cbGuiTuHuyen";
            this.cbGuiTuHuyen.Size = new System.Drawing.Size(150, 27);
            this.cbGuiTuHuyen.TabIndex = 5;
            // 
            // lblGuiDen
            // 
            this.lblGuiDen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblGuiDen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGuiDen.Location = new System.Drawing.Point(20, 160);
            this.lblGuiDen.Name = "lblGuiDen";
            this.lblGuiDen.Size = new System.Drawing.Size(100, 23);
            this.lblGuiDen.TabIndex = 6;
            this.lblGuiDen.Text = "Gửi đến";
            // 
            // cbGuiDenTinh
            // 
            this.cbGuiDenTinh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbGuiDenTinh.Font = new System.Drawing.Font("Arial", 10F);
            this.cbGuiDenTinh.ForeColor = System.Drawing.Color.Black;
            this.cbGuiDenTinh.Items.AddRange(new object[] {
            "Hà Nội",
            "TP. HCM",
            "Đà Nẵng"});
            this.cbGuiDenTinh.Location = new System.Drawing.Point(20, 190);
            this.cbGuiDenTinh.Name = "cbGuiDenTinh";
            this.cbGuiDenTinh.Size = new System.Drawing.Size(150, 27);
            this.cbGuiDenTinh.TabIndex = 7;
            // 
            // cbGuiDenHuyen
            // 
            this.cbGuiDenHuyen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbGuiDenHuyen.Font = new System.Drawing.Font("Arial", 10F);
            this.cbGuiDenHuyen.ForeColor = System.Drawing.Color.Black;
            this.cbGuiDenHuyen.Items.AddRange(new object[] {
            "Quận 1",
            "Quận 2",
            "Quận 3"});
            this.cbGuiDenHuyen.Location = new System.Drawing.Point(200, 190);
            this.cbGuiDenHuyen.Name = "cbGuiDenHuyen";
            this.cbGuiDenHuyen.Size = new System.Drawing.Size(150, 27);
            this.cbGuiDenHuyen.TabIndex = 8;
            // 
            // lblThongTinHangHoa
            // 
            this.lblThongTinHangHoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblThongTinHangHoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblThongTinHangHoa.Location = new System.Drawing.Point(20, 230);
            this.lblThongTinHangHoa.Name = "lblThongTinHangHoa";
            this.lblThongTinHangHoa.Size = new System.Drawing.Size(100, 23);
            this.lblThongTinHangHoa.TabIndex = 9;
            this.lblThongTinHangHoa.Text = "Thông tin hàng hóa";
            // 
            // rbHangHoa
            // 
            this.rbHangHoa.BackColor = System.Drawing.Color.Transparent;
            this.rbHangHoa.Font = new System.Drawing.Font("Arial", 10F);
            this.rbHangHoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbHangHoa.Location = new System.Drawing.Point(20, 260);
            this.rbHangHoa.Name = "rbHangHoa";
            this.rbHangHoa.Size = new System.Drawing.Size(104, 24);
            this.rbHangHoa.TabIndex = 10;
            this.rbHangHoa.Text = "Hàng hóa";
            this.rbHangHoa.UseVisualStyleBackColor = false;
            // 
            // rbTaiLieu
            // 
            this.rbTaiLieu.BackColor = System.Drawing.Color.Transparent;
            this.rbTaiLieu.Font = new System.Drawing.Font("Arial", 10F);
            this.rbTaiLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbTaiLieu.Location = new System.Drawing.Point(150, 260);
            this.rbTaiLieu.Name = "rbTaiLieu";
            this.rbTaiLieu.Size = new System.Drawing.Size(104, 24);
            this.rbTaiLieu.TabIndex = 11;
            this.rbTaiLieu.Text = "Tài liệu";
            this.rbTaiLieu.UseVisualStyleBackColor = false;
            // 
            // lblKhoiLuong
            // 
            this.lblKhoiLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblKhoiLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKhoiLuong.Location = new System.Drawing.Point(20, 300);
            this.lblKhoiLuong.Name = "lblKhoiLuong";
            this.lblKhoiLuong.Size = new System.Drawing.Size(100, 23);
            this.lblKhoiLuong.TabIndex = 12;
            this.lblKhoiLuong.Text = "Khối lượng (g)";
            // 
            // txtKhoiLuong
            // 
            this.txtKhoiLuong.BackColor = System.Drawing.Color.White;
            this.txtKhoiLuong.Font = new System.Drawing.Font("Arial", 10F);
            this.txtKhoiLuong.ForeColor = System.Drawing.Color.Black;
            this.txtKhoiLuong.Location = new System.Drawing.Point(20, 330);
            this.txtKhoiLuong.Name = "txtKhoiLuong";
            this.txtKhoiLuong.Size = new System.Drawing.Size(150, 27);
            this.txtKhoiLuong.TabIndex = 13;
            // 
            // lblKichThuoc
            // 
            this.lblKichThuoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblKichThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKichThuoc.Location = new System.Drawing.Point(20, 370);
            this.lblKichThuoc.Name = "lblKichThuoc";
            this.lblKichThuoc.Size = new System.Drawing.Size(100, 23);
            this.lblKichThuoc.TabIndex = 14;
            this.lblKichThuoc.Text = "Kích thước hàng hóa";
            // 
            // txtDai
            // 
            this.txtDai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDai.ForeColor = System.Drawing.Color.Black;
            this.txtDai.Location = new System.Drawing.Point(20, 400);
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(100, 22);
            this.txtDai.TabIndex = 15;
            // 
            // txtRong
            // 
            this.txtRong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRong.ForeColor = System.Drawing.Color.Black;
            this.txtRong.Location = new System.Drawing.Point(137, 400);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(117, 22);
            this.txtRong.TabIndex = 16;
            // 
            // txtCao
            // 
            this.txtCao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCao.ForeColor = System.Drawing.Color.Black;
            this.txtCao.Location = new System.Drawing.Point(274, 400);
            this.txtCao.Name = "txtCao";
            this.txtCao.Size = new System.Drawing.Size(114, 22);
            this.txtCao.TabIndex = 17;
            // 
            // btnTraCuuCuoc
            // 
            this.btnTraCuuCuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnTraCuuCuoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnTraCuuCuoc.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuCuoc.Location = new System.Drawing.Point(83, 496);
            this.btnTraCuuCuoc.Name = "btnTraCuuCuoc";
            this.btnTraCuuCuoc.Size = new System.Drawing.Size(224, 54);
            this.btnTraCuuCuoc.TabIndex = 18;
            this.btnTraCuuCuoc.Text = "Tra cứu cước";
            this.btnTraCuuCuoc.UseVisualStyleBackColor = false;
            this.btnTraCuuCuoc.Click += new System.EventHandler(this.btnTraCuuCuoc_Click);
            // 
            // TraCuuCP
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(409, 600);
            this.Controls.Add(this.lblTuyenDuong);
            this.Controls.Add(this.rbTrongNuoc);
            this.Controls.Add(this.rbQuocTe);
            this.Controls.Add(this.lblGuiTu);
            this.Controls.Add(this.cbGuiTuTinh);
            this.Controls.Add(this.cbGuiTuHuyen);
            this.Controls.Add(this.lblGuiDen);
            this.Controls.Add(this.cbGuiDenTinh);
            this.Controls.Add(this.cbGuiDenHuyen);
            this.Controls.Add(this.lblThongTinHangHoa);
            this.Controls.Add(this.rbHangHoa);
            this.Controls.Add(this.rbTaiLieu);
            this.Controls.Add(this.lblKhoiLuong);
            this.Controls.Add(this.txtKhoiLuong);
            this.Controls.Add(this.lblKichThuoc);
            this.Controls.Add(this.txtDai);
            this.Controls.Add(this.txtRong);
            this.Controls.Add(this.txtCao);
            this.Controls.Add(this.btnTraCuuCuoc);
            this.Name = "TraCuuCP";
            this.Text = "Tính trước cước phí";
            this.Load += new System.EventHandler(this.TraCuuCP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTuyenDuong;
        private RadioButton rbTrongNuoc;
        private RadioButton rbQuocTe;
        private Label lblGuiTu;
        private ComboBox cbGuiTuTinh;
        private ComboBox cbGuiTuHuyen;
        private Label lblGuiDen;
        private ComboBox cbGuiDenTinh;
        private ComboBox cbGuiDenHuyen;
        private Label lblThongTinHangHoa;
        private RadioButton rbHangHoa;
        private RadioButton rbTaiLieu;
        private Label lblKhoiLuong;
        private TextBox txtKhoiLuong;
        private Label lblKichThuoc;
        private TextBox txtDai;
        private TextBox txtRong;
        private TextBox txtCao;
        private Button btnTraCuuCuoc;
    }
}