namespace Post_Nhanh
{
    partial class Hoanthanh
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblMaDonHang;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.Label lblThongTinNguoiNhan;
        private System.Windows.Forms.Button btnTaoDonMoi;
        private System.Windows.Forms.Button btnXemChiTiet;

        /// <summary>
        /// Dọn dẹp các tài nguyên đang sử dụng.
        /// </summary>
        /// <param name="disposing">Xác định xem tài nguyên cần được giải phóng hay không.</param>
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
        /// Thiết kế giao diện cho form Hoàn thành.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lblMaDonHang = new System.Windows.Forms.Label();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblThongTinNguoiNhan = new System.Windows.Forms.Label();
            this.btnTaoDonMoi = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.pbIconSuccess = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblThongBao.ForeColor = System.Drawing.Color.Green;
            this.lblThongBao.Location = new System.Drawing.Point(120, 32);
            this.lblThongBao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(344, 29);
            this.lblThongBao.TabIndex = 0;
            this.lblThongBao.Text = "Đơn hàng đã tạo thành công!";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaDonHang
            // 
            this.lblMaDonHang.AutoSize = true;
            this.lblMaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMaDonHang.Location = new System.Drawing.Point(133, 71);
            this.lblMaDonHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaDonHang.Name = "lblMaDonHang";
            this.lblMaDonHang.Size = new System.Drawing.Size(169, 20);
            this.lblMaDonHang.TabIndex = 1;
            this.lblMaDonHang.Text = "Mã đơn hàng: XYZ123";
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNgayTao.Location = new System.Drawing.Point(133, 101);
            this.lblNgayTao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(160, 20);
            this.lblNgayTao.TabIndex = 2;
            this.lblNgayTao.Text = "Ngày tạo: 18/10/2024";
            // 
            // lblThongTinNguoiNhan
            // 
            this.lblThongTinNguoiNhan.AutoSize = true;
            this.lblThongTinNguoiNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblThongTinNguoiNhan.Location = new System.Drawing.Point(133, 130);
            this.lblThongTinNguoiNhan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongTinNguoiNhan.Name = "lblThongTinNguoiNhan";
            this.lblThongTinNguoiNhan.Size = new System.Drawing.Size(256, 20);
            this.lblThongTinNguoiNhan.TabIndex = 3;
            this.lblThongTinNguoiNhan.Text = "Người nhận: Nguyễn Văn A, Hà Nội";
            // 
            // btnTaoDonMoi
            // 
            this.btnTaoDonMoi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTaoDonMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnTaoDonMoi.ForeColor = System.Drawing.Color.White;
            this.btnTaoDonMoi.Location = new System.Drawing.Point(100, 195);
            this.btnTaoDonMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaoDonMoi.Name = "btnTaoDonMoi";
            this.btnTaoDonMoi.Size = new System.Drawing.Size(147, 32);
            this.btnTaoDonMoi.TabIndex = 4;
            this.btnTaoDonMoi.Text = "Tạo đơn hàng mới";
            this.btnTaoDonMoi.UseVisualStyleBackColor = false;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXemChiTiet.Location = new System.Drawing.Point(300, 195);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(147, 32);
            this.btnXemChiTiet.TabIndex = 5;
            this.btnXemChiTiet.Text = "Trang Chủ";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            // 
            // pbIconSuccess
            // 
            this.pbIconSuccess.Location = new System.Drawing.Point(33, 26);
            this.pbIconSuccess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbIconSuccess.Name = "pbIconSuccess";
            this.pbIconSuccess.Size = new System.Drawing.Size(67, 65);
            this.pbIconSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconSuccess.TabIndex = 6;
            this.pbIconSuccess.TabStop = false;
            // 
            // Hoanthanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.pbIconSuccess);
            this.Controls.Add(this.btnTaoDonMoi);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.lblThongTinNguoiNhan);
            this.Controls.Add(this.lblNgayTao);
            this.Controls.Add(this.lblMaDonHang);
            this.Controls.Add(this.lblThongBao);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Hoanthanh";
            this.Text = "Hoàn thành tạo đơn hàng";
            ((System.ComponentModel.ISupportInitialize)(this.pbIconSuccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIconSuccess;
    }
}
