namespace Post_Nhanh
{
    partial class HoanThanh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.Label lblThongTinNguoiNhan;
        private System.Windows.Forms.Button btnTaoDonMoi;
        private System.Windows.Forms.Button btnXemChiTiet;

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
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblThongTinNguoiNhan = new System.Windows.Forms.Label();
            this.btnTaoDonMoi = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaDonHang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblThongBao.ForeColor = System.Drawing.Color.Green;
            this.lblThongBao.Location = new System.Drawing.Point(153, 40);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(427, 36);
            this.lblThongBao.TabIndex = 0;
            this.lblThongBao.Text = "Đơn hàng đã tạo thành công!";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNgayTao.Location = new System.Drawing.Point(124, 126);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(109, 25);
            this.lblNgayTao.TabIndex = 2;
            this.lblNgayTao.Text = "Ngày Tạo: ";
            // 
            // lblThongTinNguoiNhan
            // 
            this.lblThongTinNguoiNhan.AutoSize = true;
            this.lblThongTinNguoiNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblThongTinNguoiNhan.Location = new System.Drawing.Point(124, 161);
            this.lblThongTinNguoiNhan.Name = "lblThongTinNguoiNhan";
            this.lblThongTinNguoiNhan.Size = new System.Drawing.Size(121, 25);
            this.lblThongTinNguoiNhan.TabIndex = 3;
            this.lblThongTinNguoiNhan.Text = "Người Nhận:";
            // 
            // btnTaoDonMoi
            // 
            this.btnTaoDonMoi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTaoDonMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnTaoDonMoi.ForeColor = System.Drawing.Color.White;
            this.btnTaoDonMoi.Location = new System.Drawing.Point(85, 288);
            this.btnTaoDonMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoDonMoi.Name = "btnTaoDonMoi";
            this.btnTaoDonMoi.Size = new System.Drawing.Size(196, 40);
            this.btnTaoDonMoi.TabIndex = 4;
            this.btnTaoDonMoi.Text = "Tạo đơn hàng mới";
            this.btnTaoDonMoi.UseVisualStyleBackColor = false;
            this.btnTaoDonMoi.Click += new System.EventHandler(this.btnTaoDonMoi_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXemChiTiet.Location = new System.Drawing.Point(336, 288);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(196, 40);
            this.btnXemChiTiet.TabIndex = 5;
            this.btnXemChiTiet.Text = "Trang Chủ";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(124, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Đơn Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(267, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 7;
            // 
            // lblMaDonHang
            // 
            this.lblMaDonHang.AutoSize = true;
            this.lblMaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMaDonHang.Location = new System.Drawing.Point(281, 92);
            this.lblMaDonHang.Name = "lblMaDonHang";
            this.lblMaDonHang.Size = new System.Drawing.Size(0, 25);
            this.lblMaDonHang.TabIndex = 1;
            this.lblMaDonHang.Click += new System.EventHandler(this.lblMaDonHang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(258, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(124, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(124, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số Điện Thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(273, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 11;
            // 
            // HoanThanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTaoDonMoi);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.lblThongTinNguoiNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNgayTao);
            this.Controls.Add(this.lblMaDonHang);
            this.Controls.Add(this.lblThongBao);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HoanThanh";
            this.Text = "Hoàn Thành";
            this.Load += new System.EventHandler(this.HoanThanh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaDonHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
